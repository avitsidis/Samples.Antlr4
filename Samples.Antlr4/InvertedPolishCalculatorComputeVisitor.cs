using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Samples.Antlr4
{
    public class InvertedPolishCalculatorComputeVisitor : InvertedPolishCalculatorBaseVisitor<decimal>
    {
        private Dictionary<string, Func<decimal, decimal, decimal>> operations = new Dictionary<string, Func<decimal, decimal, decimal>>
        {
            {"+", (a,b) => a+b },
            {"-", (a,b) => a-b },
            {"*", (a,b) => a*b },
            {"/", (a,b) => a/b }
        };

        private decimal ParseContext(IParseTree tree)
        {
            return decimal.Parse(tree.GetText());
        }

        public override decimal VisitNumber([NotNull] InvertedPolishCalculatorParser.NumberContext context)
        {
            return ParseContext(context.NUMBER());
        }

        public override decimal VisitNegative([NotNull] InvertedPolishCalculatorParser.NegativeContext context)
        {
            return ParseContext(context.NEGATIVE_NUMBER());
        }

        public override decimal VisitOperande([NotNull] InvertedPolishCalculatorParser.OperandeContext context)
        {
            if(context.negative() != null)
            {
                return VisitNegative(context.negative());
            }
            return VisitNumber(context.number());
        }

        public override decimal VisitExpression([NotNull] InvertedPolishCalculatorParser.ExpressionContext context)
        {
            if (context.operande() != null)
            {
                return VisitOperande(context.operande());
            }
            return VisitOperation(context.operation());
        }

        public override decimal VisitOperation([NotNull] InvertedPolishCalculatorParser.OperationContext context)
        {
            var op = context.OPERATOR().GetText();
            return operations[op](VisitOperande(context.operande()), VisitExpression(context.expression()));
        }

    }
}
