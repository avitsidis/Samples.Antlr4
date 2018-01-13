using System;
using System.Linq;

namespace Samples.Antlr4
{
    public class Program
    {
        public string Execute(string[] args)
        {
            string result = "";
            if (!args.Any())
                throw new InvalidOperationException("You must provide a reverse polish expression");
            var input = string.Join(" ",args);
            var calculator = new InvertedPolishCalculator();
            result = calculator.Compute(input).ToString();
            return result;
        }

        static int Main(string[] args)
        {
            const int success = 0;
            const int error = 1;

            try
            {
                var program = new Program();
                Console.WriteLine(program.Execute(args));
                return success;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error : {e.Message}");
                return error;
            }
        }
    }
}
