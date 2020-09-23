using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;
            result = calculator.Add(5);
            Console.WriteLine("Result: {0}", result);

            result = calculator.Add(45);
            Console.WriteLine("Result: {0}", result);

            result = calculator.Add(9);
            Console.WriteLine("Result: {0}", result);

            result = calculator.Mult(3);
            Console.WriteLine("Result: {0}", result);

            result = calculator.Sub(7);
            Console.WriteLine("Result: {0}", result);

            result = calculator.Divide(5);
            Console.WriteLine("Result: {0}", result);
            
            result = calculator.Redo(2);
            Console.WriteLine("Redo result: {0}", result);

            result = calculator.Undo(1);
            Console.WriteLine("Undo result: {0}", result);
            
        }
    }
}
