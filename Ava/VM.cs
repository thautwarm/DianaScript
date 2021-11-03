using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ava
{
    using static VMExts;

    public enum CONT
    {
        NORMAL = 0,
        Break = 1,
        CONTINUE = 2,
        RETURN = 3
    }

    [Serializable]
    public enum BC
    {
        LOAD_GLOBAL,
        LOAD_GLOBAL_REF,
        STORE_GLOBAL,
        LOAD_LOCAL,
        LOAD_LOCAL_REF,
        STORE_LOCAL,

        LOAD_FREE,
        LOAD_FREE_REF,
        STORE_FREE,

        STORE_ITEM,
        LOAD_ITEM_REF,
        LOAD_ITEM,
        CALL_FUNC,
        CALL_PRIME2,
        GOTO,
        GOTO_IF_NOT,
        GOTO_IF_AND_NO_POP,
        GOTO_IF_NOT_AND_NO_POP,
        NOT,
        PUSHCONST,
        RETURN,
        RAISE,
        DUP,
        POP,
        MK_FUNC,
        MK_LIST,
        MK_TUPLE,
        MK_DICT,
        NEG,
        INV,
        MK_STRDICT,
        FOR,
        GET_NEXT,
        BADD,
        BSUB,
        BLT,
        DUP2,
    }

    public static class VMExts
    {
        public const int PSEUDO = 0;
    }

    public static class ListExt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Push<T>(this List<T> self, T o)
        {
            self.Add(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]

        public static T Peek<T>(this List<T> self)
        {
            return self[self.Count - 1];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Pop<T>(this List<T> self)
        {
            var i = self.Count - 1;
            var a = self[i];
            self.RemoveAt(i);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (T, T) Pop2<T>(this List<T> self)
        {
            var i = self.Count - 1;
            var a = self[i - 1];
            var b = self[i];
            self.RemoveAt(i);
            self.RemoveAt(i - 1);
            return (a, b);
        }
    }
    public static class VM
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DObj execute(CodeObject co, DObj[] localvars, DObj[] freevars, Dictionary<string, DObj> nameSpace)
        {
            List<DObj> vstack = new List<DObj>();
            int offset = 0;


            DObj loadvar(int _i)
            {
                DObj r;
                if (_i < 0)
                {
                    _i = -_i - 1;
                    r = freevars[_i];
                    if (r == null)
                        throw new NameError("free", co.freenames[_i]);
                    return r;
                }
                r = localvars[_i];
                if (r == null)
                    throw new NameError("local", co.localnames[_i]);
                return r;
            }

            var bytecode = co.bytecode;
            var end = bytecode.Length;

            try
            {
            head:
                if (offset < end)
                {
                    switch (bytecode[offset])
                    {
                        case (int)BC.NEG:
                            {
                                vstack.Push(vstack.Pop().__neg__());
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.NOT:
                            {
                                var i = vstack.Count - 1;
                                vstack[i] = MK.Int(!(vstack[i].__bool__()));
                                offset += 1;
                                goto head;
                            }
                        case (int)BC.INV:
                            {
                                vstack.Push(vstack.Pop().__inv__());
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.BLT:
                            {
                                var i = vstack.Count - 1;
                                vstack[i - 1] = MK.Int(vstack[i - 1].__lt__(vstack[i]));
                                vstack.RemoveAt(i);
                                offset += 1;
                                goto head;
                            }
                        case (int)BC.BADD:
                            {

                                var i = vstack.Count - 1;
                                var r = vstack[i];
                                vstack[i - 1] = vstack[i - 1].__add__(r);
                                vstack.RemoveAt(i);
                                // var (l, r) = vstack.Pop2();
                                // vstack.Push(l.__add__(r));
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.BSUB:
                            {
                                var (l, r) = vstack.Pop2();
                                vstack.Push(l.__sub__(r));
                                offset += 1;
                                goto head;
                            }
                        case (int)BC.MK_STRDICT:
                            {
                                var n = bytecode[offset + 1];
                                var xs = new Dictionary<string, DObj>();

                                for (int i = 0; i < n; i++)
                                {
                                    var v = vstack.Pop();
                                    var k = (string)(DString)vstack.Pop();
                                    if (!xs.ContainsKey(k))
                                        xs[k] = v;
                                }

                                vstack.Push(MK.StrDict(xs));
                                offset += 2;
                                goto head;
                            }
                        case (int)BC.MK_DICT:
                            {
                                var n = bytecode[offset + 1];
                                var xs = new Dictionary<DObj, DObj>();

                                for (int i = 0; i < n; i++)
                                {
                                    var (k, v) = vstack.Pop2();
                                    if (!xs.ContainsKey(k))
                                        xs[k] = v;
                                }

                                vstack.Push(MK.Dict(xs));
                                offset += 2;
                                goto head;
                            }
                        case (int)BC.MK_LIST:
                            {
                                var n = bytecode[offset + 1];
                                var xs = new List<DObj>();

                                for (int i = 0; i < n; i++)
                                    xs.Add(vstack.Pop());
                                xs.Reverse();
                                vstack.Push(MK.List(xs));
                                offset += 2;
                                goto head;
                            }
                        case (int)BC.MK_TUPLE:
                            {
                                var n = bytecode[offset + 1];
                                var xs = new DObj[n];

                                for (int i = n - 1; i >= 0; i--)
                                    xs[i] = vstack.Pop();
                                vstack.Push(MK.Tuple(xs));
                                offset += 2;
                                goto head;
                            }
                        case (int)BC.LOAD_GLOBAL:
                            {
                                var s = co.strings[bytecode[offset + 1]];
                                if (nameSpace.TryGetValue(s, out var v))
                                    vstack.Push(v);
                                else
                                    throw new NameError("global", s);
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.STORE_GLOBAL:
                            {
                                var s = co.strings[bytecode[offset + 1]];
                                nameSpace[s] = vstack.Pop();
                                offset += 2;
                                goto head;
                            }


                        case (int)BC.LOAD_FREE:
                            {
                                var r = freevars[bytecode[offset + 1]];
                                if (r == null)
                                    throw new NameError("free", co.freenames[bytecode[offset + 1]]);
                                vstack.Push(r);
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.STORE_FREE:
                            {
                                freevars[bytecode[offset + 1]] = vstack.Pop();
                                offset += 2;
                                goto head;
                            }


                        case (int)BC.LOAD_LOCAL:
                            {
                                var r = localvars[bytecode[offset + 1]];
                                if (r == null)
                                    throw new NameError("local", co.localnames[bytecode[offset + 1]]);
                                vstack.Push(r);
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.STORE_LOCAL:
                            {
                                localvars[bytecode[offset + 1]] = vstack.Pop();
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.LOAD_ITEM:
                            {
                                var item = vstack.Pop();
                                var subject = vstack.Pop();
                                vstack.Push(subject.__get__(item));
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.STORE_ITEM:
                            {
                                var value = vstack.Pop();
                                var item = vstack.Pop();
                                var subject = vstack.Pop();
                                subject.__set__(item, value);
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.CALL_FUNC:
                            {
                                var n = bytecode[offset + 1];
                                var arr = new DObj[n];
                                for (var i = n - 1; i >= 0; i--)
                                {
                                    arr[i] = vstack.Pop();
                                }
                                var f = vstack.Pop();
                                vstack.Push(f.__call__(arr));
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.CALL_PRIME2:
                            {
                                var arg2 = vstack.Pop();
                                var arg1 = vstack.Pop();
                                vstack.Push(Prime2.callfunc2(bytecode[offset + 1], arg1, arg2));
                                offset += 2;
                                goto head;
                            }

                        case (int)BC.GOTO:
                            {
                                offset = bytecode[offset + 1];
                                goto head;
                            }

                        case (int)BC.GOTO_IF_NOT:
                            {
                                if (!vstack.Pop().__bool__())
                                    offset = bytecode[offset + 1];
                                else
                                {
                                    offset += 2;
                                }
                                goto head;
                            }

                        case (int)BC.GOTO_IF_AND_NO_POP:
                            {
                                var value = vstack.Pop();
                                if (value.__bool__())
                                {
                                    vstack.Push(value);
                                    offset = bytecode[offset + 1];
                                }
                                else
                                {
                                    offset += 2;
                                }
                                goto head;
                            }
                        case (int)BC.GOTO_IF_NOT_AND_NO_POP:
                            {
                                var value = vstack.Pop();
                                if (!value.__bool__())
                                {
                                    offset = bytecode[offset + 1];
                                }
                                else
                                {
                                    vstack.Push(value);
                                    offset += 2;
                                }
                                goto head;
                            }

                        case (int)BC.PUSHCONST:
                            vstack.Push(co.consts[bytecode[offset + 1]]);
                            offset += 2;
                            goto head;
                        case (int)BC.RETURN:
                            return vstack.Pop();

                        case (int)BC.RAISE:
                            throw new ValueError(vstack.Pop().__str__());
                        case (int)BC.DUP:
                            vstack.Push(vstack.Peek());
                            offset += 1;
                            goto head;
                        case (int)BC.DUP2:
                            {
                                var i = vstack.Count;
                                vstack.Push(vstack[i - 2]);
                                vstack.Push(vstack[i - 1]);
                                offset += 1;
                                goto head;
                            }
                        case (int)BC.POP:
                            vstack.Pop();
                            offset += 1;
                            goto head;
                        case (int)BC.MK_FUNC:
                            {
                                var code = (CodeObject)vstack.Pop();
                                var sub_freevars = new DObj[code.freenames.Length];
                                var n = bytecode[offset + 1];
                                for (int i = 0; i < n; i++)
                                {
                                    var j = offset + 2 + i + i;
                                    var from = bytecode[j];
                                    var to = bytecode[j + 1];
                                    freevars[to] = loadvar(from);
                                }
                                vstack.Push(new DObjectFunc(code, sub_freevars, nameSpace));
                                offset += 2 + n + n;
                                goto head;
                            }
                        case (int)BC.FOR:
                            {
                                var o = vstack.Pop();
                                vstack.Push(new DEnum(o.__iter__().GetEnumerator()));
                                offset += 1;
                                goto head;
                            }

                        case (int)BC.GET_NEXT:
                            {
                                var o = vstack.Peek();
                                o = o.__next__();
                                if (o == null)
                                {
                                    offset = bytecode[offset + 1];
                                    vstack.Pop();
                                    goto head;
                                }
                                else
                                {
                                    vstack.Push(o);
                                }
                                offset += 2;
                                goto head;
                            }
                        default:
                            throw new NotImplementedException();
                    }
                }
                if (vstack.Count != 0)
                    return vstack.Pop();
                return DNone.unique;
            }
            catch (Exception e)
            {

                SourcePos pos = co.pos;
                foreach (var (off, pos_) in co.sourcePos)
                {
                    if (offset < off)
                        break;
                    pos = pos_;
                }
                throw new DianaVMError(e, pos);

            }
        }
    }



}
