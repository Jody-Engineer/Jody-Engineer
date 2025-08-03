using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Calculator ===");
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine();

            var calculator = new Calculator();
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Available operations:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Power (^)");
                    Console.WriteLine("6. Square Root (sqrt)");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine();

                    Console.Write("Select operation (1-7): ");
                    string? choice = Console.ReadLine();

                    if (choice == "7")
                    {
                        Console.WriteLine("Thank you for using the calculator. Goodbye!");
                        break;
                    }

                    if (choice == "6") // Square root - only needs one number
                    {
                        Console.Write("Enter a number: ");
                        if (double.TryParse(Console.ReadLine(), out double number))
                        {
                            double result = calculator.SquareRoot(number);
                            Console.WriteLine($"√{number} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else if (choice is "1" or "2" or "3" or "4" or "5")
                    {
                        Console.Write("Enter first number: ");
                        if (!double.TryParse(Console.ReadLine(), out double num1))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }

                        Console.Write("Enter second number: ");
                        if (!double.TryParse(Console.ReadLine(), out double num2))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }

                        double result = choice switch
                        {
                            "1" => calculator.Add(num1, num2),
                            "2" => calculator.Subtract(num1, num2),
                            "3" => calculator.Multiply(num1, num2),
                            "4" => calculator.Divide(num1, num2),
                            "5" => calculator.Power(num1, num2),
                            _ => 0
                        };

                        string operation = choice switch
                        {
                            "1" => "+",
                            "2" => "-",
                            "3" => "*",
                            "4" => "/",
                            "5" => "^",
                            _ => ""
                        };

                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select 1-7.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public class Calculator
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Sum of a and b</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts second number from first number
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Difference of a and b</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Product of a and b</returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides first number by second number
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>Quotient of a and b</returns>
        /// <exception cref="DivideByZeroException">Thrown when divisor is zero</exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return a / b;
        }

        /// <summary>
        /// Raises first number to the power of second number
        /// </summary>
        /// <param name="baseNumber">Base number</param>
        /// <param name="exponent">Exponent</param>
        /// <returns>Result of base raised to exponent</returns>
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        /// <summary>
        /// Calculates square root of a number
        /// </summary>
        /// <param name="number">Number to find square root of</param>
        /// <returns>Square root of the number</returns>
        /// <exception cref="ArgumentException">Thrown when number is negative</exception>
        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of negative number!");
            }
            return Math.Sqrt(number);
        }
    }
}