//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Ava.Frontend.Generated/DianaScript.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Ava.Frontend {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class DianaScriptLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, COMMENT_1=36, SINGLE_BINOP_2=37, 
		STR_4=38, INT_10=39, HEX_7=40, OCT_8=41, BIN_9=42, FLOAT_11=43, NAME_13=44, 
		WS_INLINE_14=45, NEWLINE_17=46;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "COMMENT_1", "SINGLE_BINOP_2", "ESCAPED_QUOTE_3", "STR_4", 
		"WS_5", "INT_10", "HEX_7", "OCT_8", "BIN_9", "DIGIT_6", "FLOAT_11", "UCODE_12", 
		"NAME_13", "WS_INLINE_14", "CR_15", "LF_16", "NEWLINE_17"
	};


	public DianaScriptLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DianaScriptLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "'as'", "'let'", "'='", "'loop'", "'end'", "'for'", 
		"'in'", "'break'", "'continue'", "'return'", "'var'", "'do'", "','", "'.'", 
		"'['", "']'", "'('", "')'", "'None'", "'-'", "'~'", "'if'", "'fun'", "'->'", 
		"'else'", "'elif'", "':'", "'not'", "'and'", "'or'", "'|>'", "';'", "'then'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"COMMENT_1", "SINGLE_BINOP_2", "STR_4", "INT_10", "HEX_7", "OCT_8", "BIN_9", 
		"FLOAT_11", "NAME_13", "WS_INLINE_14", "NEWLINE_17"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DianaScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DianaScriptLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x30', '\x163', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x4', '\x35', '\t', '\x35', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'\"', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', 
		'$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\a', 
		'%', '\xE8', '\n', '%', '\f', '%', '\xE', '%', '\xEB', '\v', '%', '\x3', 
		'%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x5', '&', '\x103', '\n', '&', 
		'\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', 
		'(', '\a', '(', '\x10B', '\n', '(', '\f', '(', '\xE', '(', '\x10E', '\v', 
		'(', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', '*', '\x6', 
		'*', '\x115', '\n', '*', '\r', '*', '\xE', '*', '\x116', '\x3', '*', '\x3', 
		'*', '\x3', '*', '\x5', '*', '\x11C', '\n', '*', '\x3', '+', '\x3', '+', 
		'\x3', '+', '\a', '+', '\x121', '\n', '+', '\f', '+', '\xE', '+', '\x124', 
		'\v', '+', '\x3', ',', '\x3', ',', '\x3', ',', '\a', ',', '\x129', '\n', 
		',', '\f', ',', '\xE', ',', '\x12C', '\v', ',', '\x3', '-', '\x3', '-', 
		'\x3', '-', '\a', '-', '\x131', '\n', '-', '\f', '-', '\xE', '-', '\x134', 
		'\v', '-', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', '/', 
		'\x3', '/', '\x3', '\x30', '\x5', '\x30', '\x13D', '\n', '\x30', '\x3', 
		'\x31', '\x3', '\x31', '\x3', '\x31', '\a', '\x31', '\x142', '\n', '\x31', 
		'\f', '\x31', '\xE', '\x31', '\x145', '\v', '\x31', '\x3', '\x32', '\x6', 
		'\x32', '\x148', '\n', '\x32', '\r', '\x32', '\xE', '\x32', '\x149', '\x3', 
		'\x32', '\x3', '\x32', '\x3', '\x33', '\x3', '\x33', '\x3', '\x34', '\x3', 
		'\x34', '\x3', '\x35', '\x5', '\x35', '\x153', '\n', '\x35', '\x3', '\x35', 
		'\x6', '\x35', '\x156', '\n', '\x35', '\r', '\x35', '\xE', '\x35', '\x157', 
		'\x3', '\x35', '\x3', '\x35', '\x5', '\x35', '\x15C', '\n', '\x35', '\x3', 
		'\x35', '\a', '\x35', '\x15F', '\n', '\x35', '\f', '\x35', '\xE', '\x35', 
		'\x162', '\v', '\x35', '\x2', '\x2', '\x36', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', 
		'\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', 
		'\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', 
		'\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', 
		'$', 'G', '%', 'I', '&', 'K', '\'', 'M', '\x2', 'O', '(', 'Q', '\x2', 
		'S', ')', 'U', '*', 'W', '+', 'Y', ',', '[', '\x2', ']', '-', '_', '\x2', 
		'\x61', '.', '\x63', '/', '\x65', '\x2', 'g', '\x2', 'i', '\x30', '\x3', 
		'\x2', '\r', '\x3', '\x2', '\f', '\f', '\x4', '\x2', '>', '>', '@', '@', 
		'\x4', '\x2', '\'', '(', '~', '~', '\x3', '\x2', '$', '$', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', '\x2', '\x32', ';', '\x63', 
		'h', '\x3', '\x2', '\x32', '\x39', '\x3', '\x2', '\x32', '\x33', '\x3', 
		'\x2', '\x32', ';', '\x6', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x4E02', '\x9FA7', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x2', 
		'\x179', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', ']', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x63', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'k', '\x3', '\x2', '\x2', '\x2', '\x5', 'm', '\x3', '\x2', 
		'\x2', '\x2', '\a', 'o', '\x3', '\x2', '\x2', '\x2', '\t', 'r', '\x3', 
		'\x2', '\x2', '\x2', '\v', 'v', '\x3', '\x2', '\x2', '\x2', '\r', 'x', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '}', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x13', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '\x15', '\x88', '\x3', '\x2', '\x2', '\x2', '\x17', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x97', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x9E', '\x3', '\x2', '\x2', '\x2', '\x1D', '\xA2', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '\xA5', '\x3', '\x2', '\x2', '\x2', '!', '\xA7', '\x3', 
		'\x2', '\x2', '\x2', '#', '\xA9', '\x3', '\x2', '\x2', '\x2', '%', '\xAB', 
		'\x3', '\x2', '\x2', '\x2', '\'', '\xAD', '\x3', '\x2', '\x2', '\x2', 
		')', '\xAF', '\x3', '\x2', '\x2', '\x2', '+', '\xB1', '\x3', '\x2', '\x2', 
		'\x2', '-', '\xB6', '\x3', '\x2', '\x2', '\x2', '/', '\xB8', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\xBA', '\x3', '\x2', '\x2', '\x2', '\x33', '\xBD', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\xC1', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\xC4', '\x3', '\x2', '\x2', '\x2', '\x39', '\xC9', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xCE', '\x3', '\x2', '\x2', '\x2', '=', '\xD0', '\x3', 
		'\x2', '\x2', '\x2', '?', '\xD4', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\xD8', '\x3', '\x2', '\x2', '\x2', '\x43', '\xDB', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\xDE', '\x3', '\x2', '\x2', '\x2', 'G', '\xE0', '\x3', 
		'\x2', '\x2', '\x2', 'I', '\xE5', '\x3', '\x2', '\x2', '\x2', 'K', '\x102', 
		'\x3', '\x2', '\x2', '\x2', 'M', '\x104', '\x3', '\x2', '\x2', '\x2', 
		'O', '\x107', '\x3', '\x2', '\x2', '\x2', 'Q', '\x111', '\x3', '\x2', 
		'\x2', '\x2', 'S', '\x11B', '\x3', '\x2', '\x2', '\x2', 'U', '\x11D', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\x125', '\x3', '\x2', '\x2', '\x2', 
		'Y', '\x12D', '\x3', '\x2', '\x2', '\x2', '[', '\x135', '\x3', '\x2', 
		'\x2', '\x2', ']', '\x137', '\x3', '\x2', '\x2', '\x2', '_', '\x13C', 
		'\x3', '\x2', '\x2', '\x2', '\x61', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'\x63', '\x147', '\x3', '\x2', '\x2', '\x2', '\x65', '\x14D', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x14F', '\x3', '\x2', '\x2', '\x2', 'i', '\x155', 
		'\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', '}', '\x2', '\x2', 'l', '\x4', 
		'\x3', '\x2', '\x2', '\x2', 'm', 'n', '\a', '\x7F', '\x2', '\x2', 'n', 
		'\x6', '\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', '\x63', '\x2', '\x2', 
		'p', 'q', '\a', 'u', '\x2', '\x2', 'q', '\b', '\x3', '\x2', '\x2', '\x2', 
		'r', 's', '\a', 'n', '\x2', '\x2', 's', 't', '\a', 'g', '\x2', '\x2', 
		't', 'u', '\a', 'v', '\x2', '\x2', 'u', '\n', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\a', '?', '\x2', '\x2', 'w', '\f', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', 'n', '\x2', '\x2', 'y', 'z', '\a', 'q', '\x2', '\x2', 
		'z', '{', '\a', 'q', '\x2', '\x2', '{', '|', '\a', 'r', '\x2', '\x2', 
		'|', '\xE', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', 'g', '\x2', '\x2', 
		'~', '\x7F', '\a', 'p', '\x2', '\x2', '\x7F', '\x80', '\a', '\x66', '\x2', 
		'\x2', '\x80', '\x10', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', '\a', 
		'h', '\x2', '\x2', '\x82', '\x83', '\a', 'q', '\x2', '\x2', '\x83', '\x84', 
		'\a', 't', '\x2', '\x2', '\x84', '\x12', '\x3', '\x2', '\x2', '\x2', '\x85', 
		'\x86', '\a', 'k', '\x2', '\x2', '\x86', '\x87', '\a', 'p', '\x2', '\x2', 
		'\x87', '\x14', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\a', '\x64', 
		'\x2', '\x2', '\x89', '\x8A', '\a', 't', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'g', '\x2', '\x2', '\x8B', '\x8C', '\a', '\x63', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', 'm', '\x2', '\x2', '\x8D', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x8E', '\x8F', '\a', '\x65', '\x2', '\x2', '\x8F', '\x90', '\a', 
		'q', '\x2', '\x2', '\x90', '\x91', '\a', 'p', '\x2', '\x2', '\x91', '\x92', 
		'\a', 'v', '\x2', '\x2', '\x92', '\x93', '\a', 'k', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'p', '\x2', '\x2', '\x94', '\x95', '\a', 'w', '\x2', '\x2', 
		'\x95', '\x96', '\a', 'g', '\x2', '\x2', '\x96', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x98', '\a', 't', '\x2', '\x2', '\x98', '\x99', 
		'\a', 'g', '\x2', '\x2', '\x99', '\x9A', '\a', 'v', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', 'w', '\x2', '\x2', '\x9B', '\x9C', '\a', 't', '\x2', '\x2', 
		'\x9C', '\x9D', '\a', 'p', '\x2', '\x2', '\x9D', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\x9E', '\x9F', '\a', 'x', '\x2', '\x2', '\x9F', '\xA0', 
		'\a', '\x63', '\x2', '\x2', '\xA0', '\xA1', '\a', 't', '\x2', '\x2', '\xA1', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', '\x66', '\x2', 
		'\x2', '\xA3', '\xA4', '\a', 'q', '\x2', '\x2', '\xA4', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', '.', '\x2', '\x2', '\xA6', 
		' ', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\a', '\x30', '\x2', 
		'\x2', '\xA8', '\"', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\a', 
		']', '\x2', '\x2', '\xAA', '$', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', 
		'\a', '_', '\x2', '\x2', '\xAC', '&', '\x3', '\x2', '\x2', '\x2', '\xAD', 
		'\xAE', '\a', '*', '\x2', '\x2', '\xAE', '(', '\x3', '\x2', '\x2', '\x2', 
		'\xAF', '\xB0', '\a', '+', '\x2', '\x2', '\xB0', '*', '\x3', '\x2', '\x2', 
		'\x2', '\xB1', '\xB2', '\a', 'P', '\x2', '\x2', '\xB2', '\xB3', '\a', 
		'q', '\x2', '\x2', '\xB3', '\xB4', '\a', 'p', '\x2', '\x2', '\xB4', '\xB5', 
		'\a', 'g', '\x2', '\x2', '\xB5', ',', '\x3', '\x2', '\x2', '\x2', '\xB6', 
		'\xB7', '\a', '/', '\x2', '\x2', '\xB7', '.', '\x3', '\x2', '\x2', '\x2', 
		'\xB8', '\xB9', '\a', '\x80', '\x2', '\x2', '\xB9', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\xBA', '\xBB', '\a', 'k', '\x2', '\x2', '\xBB', '\xBC', 
		'\a', 'h', '\x2', '\x2', '\xBC', '\x32', '\x3', '\x2', '\x2', '\x2', '\xBD', 
		'\xBE', '\a', 'h', '\x2', '\x2', '\xBE', '\xBF', '\a', 'w', '\x2', '\x2', 
		'\xBF', '\xC0', '\a', 'p', '\x2', '\x2', '\xC0', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\xC1', '\xC2', '\a', '/', '\x2', '\x2', '\xC2', '\xC3', 
		'\a', '@', '\x2', '\x2', '\xC3', '\x36', '\x3', '\x2', '\x2', '\x2', '\xC4', 
		'\xC5', '\a', 'g', '\x2', '\x2', '\xC5', '\xC6', '\a', 'n', '\x2', '\x2', 
		'\xC6', '\xC7', '\a', 'u', '\x2', '\x2', '\xC7', '\xC8', '\a', 'g', '\x2', 
		'\x2', '\xC8', '\x38', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', 
		'g', '\x2', '\x2', '\xCA', '\xCB', '\a', 'n', '\x2', '\x2', '\xCB', '\xCC', 
		'\a', 'k', '\x2', '\x2', '\xCC', '\xCD', '\a', 'h', '\x2', '\x2', '\xCD', 
		':', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCF', '\a', '<', '\x2', '\x2', 
		'\xCF', '<', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', 'p', '\x2', 
		'\x2', '\xD1', '\xD2', '\a', 'q', '\x2', '\x2', '\xD2', '\xD3', '\a', 
		'v', '\x2', '\x2', '\xD3', '>', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', 
		'\a', '\x63', '\x2', '\x2', '\xD5', '\xD6', '\a', 'p', '\x2', '\x2', '\xD6', 
		'\xD7', '\a', '\x66', '\x2', '\x2', '\xD7', '@', '\x3', '\x2', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', 'q', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		't', '\x2', '\x2', '\xDA', '\x42', '\x3', '\x2', '\x2', '\x2', '\xDB', 
		'\xDC', '\a', '~', '\x2', '\x2', '\xDC', '\xDD', '\a', '@', '\x2', '\x2', 
		'\xDD', '\x44', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', '=', 
		'\x2', '\x2', '\xDF', '\x46', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', 
		'\a', 'v', '\x2', '\x2', '\xE1', '\xE2', '\a', 'j', '\x2', '\x2', '\xE2', 
		'\xE3', '\a', 'g', '\x2', '\x2', '\xE3', '\xE4', '\a', 'p', '\x2', '\x2', 
		'\xE4', 'H', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE9', '\a', '%', '\x2', 
		'\x2', '\xE6', '\xE8', '\n', '\x2', '\x2', '\x2', '\xE7', '\xE6', '\x3', 
		'\x2', '\x2', '\x2', '\xE8', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xE7', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', '\x2', '\x2', 
		'\x2', '\xEA', '\xEC', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xE9', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xED', '\b', '%', '\x2', '\x2', '\xED', 
		'J', '\x3', '\x2', '\x2', '\x2', '\xEE', '\x103', '\t', '\x3', '\x2', 
		'\x2', '\xEF', '\xF0', '\a', '@', '\x2', '\x2', '\xF0', '\x103', '\a', 
		'?', '\x2', '\x2', '\xF1', '\xF2', '\a', '>', '\x2', '\x2', '\xF2', '\x103', 
		'\a', '?', '\x2', '\x2', '\xF3', '\xF4', '\a', '?', '\x2', '\x2', '\xF4', 
		'\x103', '\a', '?', '\x2', '\x2', '\xF5', '\xF6', '\a', '#', '\x2', '\x2', 
		'\xF6', '\x103', '\a', '?', '\x2', '\x2', '\xF7', '\x103', '\x4', ',', 
		'-', '\x2', '\xF8', '\xF9', '\a', ',', '\x2', '\x2', '\xF9', '\x103', 
		'\a', ',', '\x2', '\x2', '\xFA', '\x103', '\a', '\x31', '\x2', '\x2', 
		'\xFB', '\xFC', '\a', '\x31', '\x2', '\x2', '\xFC', '\x103', '\a', '\x31', 
		'\x2', '\x2', '\xFD', '\x103', '\t', '\x4', '\x2', '\x2', '\xFE', '\xFF', 
		'\a', '>', '\x2', '\x2', '\xFF', '\x103', '\a', '>', '\x2', '\x2', '\x100', 
		'\x101', '\a', '@', '\x2', '\x2', '\x101', '\x103', '\a', '@', '\x2', 
		'\x2', '\x102', '\xEE', '\x3', '\x2', '\x2', '\x2', '\x102', '\xEF', '\x3', 
		'\x2', '\x2', '\x2', '\x102', '\xF1', '\x3', '\x2', '\x2', '\x2', '\x102', 
		'\xF3', '\x3', '\x2', '\x2', '\x2', '\x102', '\xF5', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\xF7', '\x3', '\x2', '\x2', '\x2', '\x102', '\xF8', '\x3', 
		'\x2', '\x2', '\x2', '\x102', '\xFA', '\x3', '\x2', '\x2', '\x2', '\x102', 
		'\xFB', '\x3', '\x2', '\x2', '\x2', '\x102', '\xFD', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\xFE', '\x3', '\x2', '\x2', '\x2', '\x102', '\x100', 
		'\x3', '\x2', '\x2', '\x2', '\x103', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\x105', '\a', '^', '\x2', '\x2', '\x105', '\x106', '\a', '$', 
		'\x2', '\x2', '\x106', 'N', '\x3', '\x2', '\x2', '\x2', '\x107', '\x10C', 
		'\a', '$', '\x2', '\x2', '\x108', '\x10B', '\x5', 'M', '\'', '\x2', '\x109', 
		'\x10B', '\n', '\x5', '\x2', '\x2', '\x10A', '\x108', '\x3', '\x2', '\x2', 
		'\x2', '\x10A', '\x109', '\x3', '\x2', '\x2', '\x2', '\x10B', '\x10E', 
		'\x3', '\x2', '\x2', '\x2', '\x10C', '\x10A', '\x3', '\x2', '\x2', '\x2', 
		'\x10C', '\x10D', '\x3', '\x2', '\x2', '\x2', '\x10D', '\x10F', '\x3', 
		'\x2', '\x2', '\x2', '\x10E', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x10F', 
		'\x110', '\a', '$', '\x2', '\x2', '\x110', 'P', '\x3', '\x2', '\x2', '\x2', 
		'\x111', '\x112', '\t', '\x6', '\x2', '\x2', '\x112', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\x113', '\x115', '\x5', '[', '.', '\x2', '\x114', '\x113', 
		'\x3', '\x2', '\x2', '\x2', '\x115', '\x116', '\x3', '\x2', '\x2', '\x2', 
		'\x116', '\x114', '\x3', '\x2', '\x2', '\x2', '\x116', '\x117', '\x3', 
		'\x2', '\x2', '\x2', '\x117', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x118', 
		'\x11C', '\x5', 'U', '+', '\x2', '\x119', '\x11C', '\x5', 'W', ',', '\x2', 
		'\x11A', '\x11C', '\x5', 'Y', '-', '\x2', '\x11B', '\x114', '\x3', '\x2', 
		'\x2', '\x2', '\x11B', '\x118', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x119', 
		'\x3', '\x2', '\x2', '\x2', '\x11B', '\x11A', '\x3', '\x2', '\x2', '\x2', 
		'\x11C', 'T', '\x3', '\x2', '\x2', '\x2', '\x11D', '\x11E', '\a', '\x32', 
		'\x2', '\x2', '\x11E', '\x122', '\a', 'z', '\x2', '\x2', '\x11F', '\x121', 
		'\t', '\a', '\x2', '\x2', '\x120', '\x11F', '\x3', '\x2', '\x2', '\x2', 
		'\x121', '\x124', '\x3', '\x2', '\x2', '\x2', '\x122', '\x120', '\x3', 
		'\x2', '\x2', '\x2', '\x122', '\x123', '\x3', '\x2', '\x2', '\x2', '\x123', 
		'V', '\x3', '\x2', '\x2', '\x2', '\x124', '\x122', '\x3', '\x2', '\x2', 
		'\x2', '\x125', '\x126', '\a', '\x32', '\x2', '\x2', '\x126', '\x12A', 
		'\a', 'q', '\x2', '\x2', '\x127', '\x129', '\t', '\b', '\x2', '\x2', '\x128', 
		'\x127', '\x3', '\x2', '\x2', '\x2', '\x129', '\x12C', '\x3', '\x2', '\x2', 
		'\x2', '\x12A', '\x128', '\x3', '\x2', '\x2', '\x2', '\x12A', '\x12B', 
		'\x3', '\x2', '\x2', '\x2', '\x12B', 'X', '\x3', '\x2', '\x2', '\x2', 
		'\x12C', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12D', '\x12E', '\a', 
		'\x32', '\x2', '\x2', '\x12E', '\x132', '\a', '\x64', '\x2', '\x2', '\x12F', 
		'\x131', '\t', '\t', '\x2', '\x2', '\x130', '\x12F', '\x3', '\x2', '\x2', 
		'\x2', '\x131', '\x134', '\x3', '\x2', '\x2', '\x2', '\x132', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '\x132', '\x133', '\x3', '\x2', '\x2', '\x2', 
		'\x133', 'Z', '\x3', '\x2', '\x2', '\x2', '\x134', '\x132', '\x3', '\x2', 
		'\x2', '\x2', '\x135', '\x136', '\t', '\n', '\x2', '\x2', '\x136', '\\', 
		'\x3', '\x2', '\x2', '\x2', '\x137', '\x138', '\x5', 'S', '*', '\x2', 
		'\x138', '\x139', '\a', '\x30', '\x2', '\x2', '\x139', '\x13A', '\x5', 
		'S', '*', '\x2', '\x13A', '^', '\x3', '\x2', '\x2', '\x2', '\x13B', '\x13D', 
		'\t', '\v', '\x2', '\x2', '\x13C', '\x13B', '\x3', '\x2', '\x2', '\x2', 
		'\x13D', '`', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x143', '\x5', '_', 
		'\x30', '\x2', '\x13F', '\x142', '\x5', '[', '.', '\x2', '\x140', '\x142', 
		'\x5', '_', '\x30', '\x2', '\x141', '\x13F', '\x3', '\x2', '\x2', '\x2', 
		'\x141', '\x140', '\x3', '\x2', '\x2', '\x2', '\x142', '\x145', '\x3', 
		'\x2', '\x2', '\x2', '\x143', '\x141', '\x3', '\x2', '\x2', '\x2', '\x143', 
		'\x144', '\x3', '\x2', '\x2', '\x2', '\x144', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x145', '\x143', '\x3', '\x2', '\x2', '\x2', '\x146', '\x148', 
		'\t', '\f', '\x2', '\x2', '\x147', '\x146', '\x3', '\x2', '\x2', '\x2', 
		'\x148', '\x149', '\x3', '\x2', '\x2', '\x2', '\x149', '\x147', '\x3', 
		'\x2', '\x2', '\x2', '\x149', '\x14A', '\x3', '\x2', '\x2', '\x2', '\x14A', 
		'\x14B', '\x3', '\x2', '\x2', '\x2', '\x14B', '\x14C', '\b', '\x32', '\x2', 
		'\x2', '\x14C', '\x64', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14E', 
		'\a', '\xF', '\x2', '\x2', '\x14E', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'\x14F', '\x150', '\a', '\f', '\x2', '\x2', '\x150', 'h', '\x3', '\x2', 
		'\x2', '\x2', '\x151', '\x153', '\x5', '\x65', '\x33', '\x2', '\x152', 
		'\x151', '\x3', '\x2', '\x2', '\x2', '\x152', '\x153', '\x3', '\x2', '\x2', 
		'\x2', '\x153', '\x154', '\x3', '\x2', '\x2', '\x2', '\x154', '\x156', 
		'\x5', 'g', '\x34', '\x2', '\x155', '\x152', '\x3', '\x2', '\x2', '\x2', 
		'\x156', '\x157', '\x3', '\x2', '\x2', '\x2', '\x157', '\x155', '\x3', 
		'\x2', '\x2', '\x2', '\x157', '\x158', '\x3', '\x2', '\x2', '\x2', '\x158', 
		'\x160', '\x3', '\x2', '\x2', '\x2', '\x159', '\x15F', '\x5', '\x63', 
		'\x32', '\x2', '\x15A', '\x15C', '\x5', '\x65', '\x33', '\x2', '\x15B', 
		'\x15A', '\x3', '\x2', '\x2', '\x2', '\x15B', '\x15C', '\x3', '\x2', '\x2', 
		'\x2', '\x15C', '\x15D', '\x3', '\x2', '\x2', '\x2', '\x15D', '\x15F', 
		'\x5', 'g', '\x34', '\x2', '\x15E', '\x159', '\x3', '\x2', '\x2', '\x2', 
		'\x15E', '\x15B', '\x3', '\x2', '\x2', '\x2', '\x15F', '\x162', '\x3', 
		'\x2', '\x2', '\x2', '\x160', '\x15E', '\x3', '\x2', '\x2', '\x2', '\x160', 
		'\x161', '\x3', '\x2', '\x2', '\x2', '\x161', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\x162', '\x160', '\x3', '\x2', '\x2', '\x2', '\x16', '\x2', '\xE9', 
		'\x102', '\x10A', '\x10C', '\x116', '\x11B', '\x120', '\x122', '\x12A', 
		'\x132', '\x13C', '\x141', '\x143', '\x149', '\x152', '\x157', '\x15B', 
		'\x15E', '\x160', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Ava.Frontend
