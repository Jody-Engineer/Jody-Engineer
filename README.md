# C# Calculator Program

A comprehensive console-based calculator application written in C#.

## Features

- **Basic Operations**: Addition, Subtraction, Multiplication, Division
- **Advanced Operations**: Power calculation, Square root
- **Error Handling**: Division by zero protection, negative square root protection
- **User-Friendly Interface**: Clear menu system with input validation
- **Continuous Operation**: Loop-based interface for multiple calculations

## Operations Supported

1. **Addition (+)**: Adds two numbers
2. **Subtraction (-)**: Subtracts second number from first
3. **Multiplication (*)**: Multiplies two numbers
4. **Division (/)**: Divides first number by second (with zero-division protection)
5. **Power (^)**: Raises first number to the power of second number
6. **Square Root (√)**: Calculates square root of a number (with negative number protection)
7. **Exit**: Quit the application

## Requirements

- .NET 8.0 SDK or later
- Any operating system that supports .NET (Windows, macOS, Linux)

## How to Run

1. **Build and Run**:
   ```bash
   dotnet run
   ```

2. **Build Only**:
   ```bash
   dotnet build
   ```

3. **Run Executable** (after building):
   ```bash
   dotnet bin/Debug/net8.0/Calculator.dll
   ```

## Usage

1. Run the program using `dotnet run`
2. Select an operation from the menu (1-7)
3. Enter the required numbers when prompted
4. View the result
5. Press any key to continue for another calculation
6. Select option 7 to exit

## Example Usage

```
=== C# Calculator ===
Welcome to the Calculator!

Available operations:
1. Addition (+)
2. Subtraction (-)
3. Multiplication (*)
4. Division (/)
5. Power (^)
6. Square Root (sqrt)
7. Exit

Select operation (1-7): 1
Enter first number: 15
Enter second number: 25
15 + 25 = 40

Press any key to continue...
```

## Error Handling

The calculator includes robust error handling for:
- **Invalid input**: Non-numeric inputs are detected and handled gracefully
- **Division by zero**: Protected against division by zero with appropriate error message
- **Negative square roots**: Prevents calculation of square root for negative numbers
- **General exceptions**: Catches and displays any unexpected errors

## Code Structure

- **Program.cs**: Contains the main program logic and user interface
- **Calculator class**: Implements all mathematical operations with proper documentation
- **Calculator.csproj**: Project configuration file for .NET 8.0

## Features Highlights

- **Type Safety**: Uses `double` for all calculations to handle decimal numbers
- **Input Validation**: Robust parsing with `TryParse` methods
- **Clear Interface**: Menu-driven interface with clear instructions
- **Documentation**: Comprehensive XML documentation for all methods
- **Modern C#**: Uses latest C# features like pattern matching and switch expressions

## Contributing

Feel free to extend this calculator with additional operations such as:
- Trigonometric functions (sin, cos, tan)
- Logarithmic functions
- Memory operations
- History of calculations
- Scientific notation support
