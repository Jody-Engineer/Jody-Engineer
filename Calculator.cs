using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Calculator ===");
            Console.WriteLine("Available operations: +, -, *, /, %, ^ (power)");
            Console.WriteLine("Type 'exit' to quit the calculator");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    if (!double.TryParse(input, out double num1))
                    {
                        Console.WriteLine("Invalid number. Please try again.");
                        continue;
                    }

                    Console.Write("Enter operation (+, -, *, /, %, ^): ");
                    string operation = Console.ReadLine();

                    if (operation.ToLower() == "exit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    Console.Write("Enter second number: ");
                    input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    if (!double.TryParse(input, out double num2))
                    {
                        Console.WriteLine("Invalid number. Please try again.");
                        continue;
                    }

                    double result = Calculate(num1, num2, operation);
                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        static double Calculate(double num1, double num2, string operation)
        {
            return operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero"),
                "%" => num2 != 0 ? num1 % num2 : throw new DivideByZeroException("Cannot calculate modulo with zero"),
                "^" => Math.Pow(num1, num2),
                _ => throw new ArgumentException($"Unknown operation: {operation}")
            };
        }
    }
}