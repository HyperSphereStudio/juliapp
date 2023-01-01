//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\JohnB\Desktop\HyperProjects\Spinor\runtime\src\core\parse\SpinorParser.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace HyperSphere {
using runtime.parse;

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISpinorParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class SpinorParserBaseListener : ISpinorParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpinorParser.topExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTopExpr([NotNull] SpinorParser.TopExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpinorParser.topExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTopExpr([NotNull] SpinorParser.TopExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpinorParser.exprBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprBlock([NotNull] SpinorParser.ExprBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpinorParser.exprBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprBlock([NotNull] SpinorParser.ExprBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>tuple</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTuple([NotNull] SpinorParser.TupleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>tuple</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTuple([NotNull] SpinorParser.TupleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthetical</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthetical([NotNull] SpinorParser.ParentheticalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthetical</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthetical([NotNull] SpinorParser.ParentheticalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>struct</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStruct([NotNull] SpinorParser.StructContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>struct</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStruct([NotNull] SpinorParser.StructContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>module</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule([NotNull] SpinorParser.ModuleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>module</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule([NotNull] SpinorParser.ModuleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>block</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] SpinorParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>block</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] SpinorParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] SpinorParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] SpinorParser.NameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>literalExpr</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralExpr([NotNull] SpinorParser.LiteralExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>literalExpr</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralExpr([NotNull] SpinorParser.LiteralExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpinorParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] SpinorParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpinorParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] SpinorParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] SpinorParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] SpinorParser.FloatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInteger([NotNull] SpinorParser.IntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInteger([NotNull] SpinorParser.IntegerContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace HyperSphere