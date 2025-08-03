using System;

namespace CalculatorApp
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("==== C# Console Calculator ====");
                Console.WriteLine("Select operation:");
                Console.WriteLine("1) Addition (+)");
                Console.WriteLine("2) Subtraction (-)");
                Console.WriteLine("3) Multiplication (*)");
                Console.WriteLine("4) Division (/)");
                Console.WriteLine("5) Exit");
                Console.Write("Choice: ");

                var choice = Console.ReadLine();

                if (choice == "5" || string.IsNullOrWhiteSpace(choice))
                    break;

                if (choice is not ("1" or "2" or "3" or "4"))
                {
                    Console.WriteLine("Invalid choice.\n");
                    continue;
                }

                if (!ReadNumber("Enter first number: ", out var num1) ||
                    !ReadNumber("Enter second number: ", out var num2))
                {
                    Console.WriteLine("Invalid number input.\n");
                    continue;
                }

                try
                {
                    var result = choice switch
                    {
                        "1" => num1 + num2,
                        "2" => num1 - num2,
                        "3" => num1 * num2,
                        "4" => num2 == 0 ? throw new DivideByZeroException() : num1 / num2,
                        _ => throw new InvalidOperationException()
                    };

                    Console.WriteLine($"Result: {result}\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero.\n");
                }
            }
        }

        private static bool ReadNumber(string prompt, out double number)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            return double.TryParse(input, out number);
        }
    }
}