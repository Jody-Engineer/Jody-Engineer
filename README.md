# C# Calculator Programs

This repository contains two C# calculator implementations:

## 1. Console Calculator (`Calculator.cs`)

A simple command-line calculator that supports basic arithmetic operations.

### Features:
- Addition (+)
- Subtraction (-)
- Multiplication (*)
- Division (/)
- Modulo (%)
- Power (^)
- Error handling for division by zero
- Input validation

### How to run:
```bash
# Build the project
dotnet build Calculator.csproj

# Run the calculator
dotnet run --project Calculator.csproj
```

### Usage:
1. Enter the first number
2. Choose an operation (+, -, *, /, %, ^)
3. Enter the second number
4. View the result
5. Type 'exit' to quit

## 2. GUI Calculator (`CalculatorGUI.cs`)

A Windows Forms calculator with a graphical user interface.

### Features:
- Modern GUI with buttons
- Basic arithmetic operations
- Clear function (C)
- Negate function (±)
- Decimal point support
- Error handling with message boxes
- Professional appearance

### How to run:
```bash
# Build the project
dotnet build CalculatorGUI.csproj

# Run the calculator
dotnet run --project CalculatorGUI.csproj
```

### Usage:
- Click number buttons to input values
- Click operation buttons (+, -, ×, ÷, %) to perform calculations
- Click "=" to see the result
- Click "C" to clear
- Click "±" to negate the current number

## Requirements

- .NET 8.0 SDK or later
- For GUI version: Windows operating system (for Windows Forms)

## Building and Running

Both calculators can be built and run independently:

```bash
# Console version
dotnet run --project Calculator.csproj

# GUI version
dotnet run --project CalculatorGUI.csproj
```

The console version works on any platform that supports .NET, while the GUI version requires Windows.
