using Antlr4.Runtime;

namespace Samples.Antlr4
{
    public class InvertedPolishCalculator
    {
        public decimal Compute(string expression)
        {
            var inputStream = new AntlrInputStream(expression);
            var lexer = new InvertedPolishCalculatorLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new InvertedPolishCalculatorParser(commonTokenStream);


            var visitor = new InvertedPolishCalculatorComputeVisitor();
            var tree = parser.input();
            return visitor.Visit(tree);
            

        }
    }
}
