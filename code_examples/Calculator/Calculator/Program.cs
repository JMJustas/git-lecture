using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                throw new ArgumentException(
                    "Invalid number of arguments!\nUsage: 'arg1 operation arg2'.\nExample: 1 + 2");
            }
            
            var arg1 = int.Parse(args[0]);
            var operation = args[1];
            var arg2 = int.Parse(args[2]);

            var calculator = new Calculator();
            int result;
            
            switch (operation)
            {
                case "+":
                    result = calculator.Add(arg1, arg2);
                    break;
                case "*":
                    result = calculator.Multiply(arg1, arg2);
                    break;
                default:
                    throw new ArgumentException($"Unknown operation: {operation}");
            }
            
            Console.WriteLine(result);
        }
    }
}
