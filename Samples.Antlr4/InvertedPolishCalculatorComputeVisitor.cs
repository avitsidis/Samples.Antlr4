using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;

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

        public override decimal VisitNumber([NotNull] InvertedPolishCalculatorParser.NumberContext context)
        {
            return decimal.Parse(context.NUMBER().GetText());
        }

        public override decimal VisitExpression([NotNull] InvertedPolishCalculatorParser.ExpressionContext context)
        {
            if (context.number() != null)
            {
                return VisitNumber(context.number());
            }
            return VisitOperation(context.operation());
        }

        public override decimal VisitOperation([NotNull] InvertedPolishCalculatorParser.OperationContext context)
        {
            var op = context.OPERATOR().GetText();
            return operations[op](VisitNumber(context.number()), VisitExpression(context.expression()));
        }

    }
}
