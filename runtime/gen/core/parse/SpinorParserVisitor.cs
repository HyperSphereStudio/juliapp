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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SpinorParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface ISpinorParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpinorParser.topExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTopExpr([NotNull] SpinorParser.TopExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpinorParser.exprBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprBlock([NotNull] SpinorParser.ExprBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>functionCall</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] SpinorParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>struct</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStruct([NotNull] SpinorParser.StructContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>module</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] SpinorParser.ModuleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>block</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] SpinorParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tupleExpr</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTupleExpr([NotNull] SpinorParser.TupleExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] SpinorParser.NameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>literalExpr</c>
	/// labeled alternative in <see cref="SpinorParser.primaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpr([NotNull] SpinorParser.LiteralExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpinorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] SpinorParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SpinorParser.tuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTuple([NotNull] SpinorParser.TupleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloat([NotNull] SpinorParser.FloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>integer</c>
	/// labeled alternative in <see cref="SpinorParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger([NotNull] SpinorParser.IntegerContext context);
}
} // namespace HyperSphere
