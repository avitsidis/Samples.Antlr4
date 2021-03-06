//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\avits\Documents\Visual Studio 2017\Projects\Samples.Antlr4\Samples.Antlr4\\Grammars\InvertedPolishCalculator.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class InvertedPolishCalculatorParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NUMBER=1, NEGATIVE_NUMBER=2, FIRST_NUMBER=3, SECOND_NUMBER=4, OPERATOR=5, 
		PLUS=6, MINUS=7, MUL=8, DIV=9, WS=10;
	public const int
		RULE_input = 0, RULE_operation = 1, RULE_expression = 2, RULE_operande = 3, 
		RULE_number = 4, RULE_negative = 5;
	public static readonly string[] ruleNames = {
		"input", "operation", "expression", "operande", "number", "negative"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "NEGATIVE_NUMBER", "FIRST_NUMBER", "SECOND_NUMBER", "OPERATOR", 
		"PLUS", "MINUS", "MUL", "DIV", "WS"
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

	public override string GrammarFileName { get { return "InvertedPolishCalculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static InvertedPolishCalculatorParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public InvertedPolishCalculatorParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public InvertedPolishCalculatorParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class InputContext : ParserRuleContext {
		public OperationContext operation() {
			return GetRuleContext<OperationContext>(0);
		}
		public InputContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_input; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterInput(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitInput(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInput(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InputContext input() {
		InputContext _localctx = new InputContext(Context, State);
		EnterRule(_localctx, 0, RULE_input);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12; operation();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperationContext : ParserRuleContext {
		public OperandeContext operande() {
			return GetRuleContext<OperandeContext>(0);
		}
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode OPERATOR() { return GetToken(InvertedPolishCalculatorParser.OPERATOR, 0); }
		public OperationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operation; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterOperation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitOperation(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOperation(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OperationContext operation() {
		OperationContext _localctx = new OperationContext(Context, State);
		EnterRule(_localctx, 2, RULE_operation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; operande();
			State = 15; expression();
			State = 16; Match(OPERATOR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public OperationContext operation() {
			return GetRuleContext<OperationContext>(0);
		}
		public OperandeContext operande() {
			return GetRuleContext<OperandeContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 4, RULE_expression);
		try {
			State = 20;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 18; operation();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 19; operande();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperandeContext : ParserRuleContext {
		public NegativeContext negative() {
			return GetRuleContext<NegativeContext>(0);
		}
		public NumberContext number() {
			return GetRuleContext<NumberContext>(0);
		}
		public OperandeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operande; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterOperande(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitOperande(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOperande(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OperandeContext operande() {
		OperandeContext _localctx = new OperandeContext(Context, State);
		EnterRule(_localctx, 6, RULE_operande);
		try {
			State = 24;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NEGATIVE_NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22; negative();
				}
				break;
			case NUMBER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23; number();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberContext : ParserRuleContext {
		public ITerminalNode NUMBER() { return GetToken(InvertedPolishCalculatorParser.NUMBER, 0); }
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 8, RULE_number);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NegativeContext : ParserRuleContext {
		public ITerminalNode NEGATIVE_NUMBER() { return GetToken(InvertedPolishCalculatorParser.NEGATIVE_NUMBER, 0); }
		public NegativeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_negative; } }
		public override void EnterRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.EnterNegative(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IInvertedPolishCalculatorListener typedListener = listener as IInvertedPolishCalculatorListener;
			if (typedListener != null) typedListener.ExitNegative(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IInvertedPolishCalculatorVisitor<TResult> typedVisitor = visitor as IInvertedPolishCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNegative(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NegativeContext negative() {
		NegativeContext _localctx = new NegativeContext(Context, State);
		EnterRule(_localctx, 10, RULE_negative);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28; Match(NEGATIVE_NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\f', '!', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x5', '\x4', '\x17', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x5', '\x5', '\x1B', '\n', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x2', '\x2', '\b', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\x2', '\x2', '\x2', '\x1C', '\x2', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x10', '\x3', '\x2', '\x2', '\x2', '\x6', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\b', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\n', '\x1C', '\x3', '\x2', '\x2', '\x2', '\f', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\xF', '\x5', '\x4', '\x3', '\x2', '\xF', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\x5', '\b', '\x5', '\x2', 
		'\x11', '\x12', '\x5', '\x6', '\x4', '\x2', '\x12', '\x13', '\a', '\a', 
		'\x2', '\x2', '\x13', '\x5', '\x3', '\x2', '\x2', '\x2', '\x14', '\x17', 
		'\x5', '\x4', '\x3', '\x2', '\x15', '\x17', '\x5', '\b', '\x5', '\x2', 
		'\x16', '\x14', '\x3', '\x2', '\x2', '\x2', '\x16', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\a', '\x3', '\x2', '\x2', '\x2', '\x18', '\x1B', 
		'\x5', '\f', '\a', '\x2', '\x19', '\x1B', '\x5', '\n', '\x6', '\x2', '\x1A', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\t', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\a', 
		'\x3', '\x2', '\x2', '\x1D', '\v', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\a', '\x4', '\x2', '\x2', '\x1F', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '\x16', '\x1A',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
