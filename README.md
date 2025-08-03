# C# Calculator

A comprehensive calculator application written in C# with both console and GUI interfaces.

## Features

### Console Calculator (`Calculator.cs`)
- Basic arithmetic operations: +, -, *, /
- Advanced operations: % (modulo), ^ (power)
- Input validation and error handling
- Interactive command-line interface
- Type 'exit' to quit

### GUI Calculator (`CalculatorGUI.cs`)
- Modern Windows Forms interface
- Dark theme with orange accent colors
- All basic arithmetic operations
- Additional features: percentage, negation, power
- Error handling with user-friendly messages
- Professional calculator layout

## Requirements

- .NET 6.0 SDK or later
- Windows OS (for GUI version)
- Linux/macOS (for console version only)

## Installation and Usage

### Quick Start

1. **Build the project:**
   ```bash
   ./build.sh
   ```

2. **Run the console calculator:**
   ```bash
   dotnet run Calculator.cs
   ```

3. **Run the GUI calculator:**
   ```bash
   dotnet run CalculatorGUI.cs
   ```

### Manual Build

1. **Build the project:**
   ```bash
   dotnet build
   ```

2. **Run console calculator:**
   ```bash
   dotnet run --project Calculator.csproj
   ```

3. **Run GUI calculator:**
   ```bash
   dotnet run --project CalculatorGUI.csproj
   ```

## Console Calculator Usage

1. Enter the first number
2. Choose an operation (+, -, *, /, %, ^)
3. Enter the second number
4. View the result
5. Type 'exit' to quit

Example:
```
Enter first number: 10
Enter operation (+, -, *, /, %, ^): +
Enter second number: 5
Result: 10 + 5 = 15
```

## GUI Calculator Usage

- Click number buttons to input values
- Use operation buttons (+, -, ×, ÷, ^) for calculations
- Press '=' to see the result
- 'C' clears the calculator
- '±' negates the current number
- '%' converts to percentage

## Project Structure

```
├── Calculator.cs          # Console calculator application
├── CalculatorGUI.cs       # GUI calculator application
├── Calculator.csproj      # Project file
├── build.sh              # Build script
└── README.md             # This file
```

## Features Overview

### Console Calculator
- ✅ Addition, subtraction, multiplication, division
- ✅ Modulo operation
- ✅ Power/exponentiation
- ✅ Input validation
- ✅ Error handling
- ✅ Interactive interface

### GUI Calculator
- ✅ Modern dark theme interface
- ✅ All basic arithmetic operations
- ✅ Percentage calculation
- ✅ Number negation
- ✅ Power/exponentiation
- ✅ Error handling with message boxes
- ✅ Professional button layout
- ✅ Real-time display updates

## Error Handling

Both calculators include comprehensive error handling:
- Division by zero protection
- Invalid input validation
- Overflow protection
- User-friendly error messages

## Contributing

Feel free to extend the calculator with additional features such as:
- Scientific calculator functions
- Memory operations
- History tracking
- Keyboard support
- Additional themes

## License

This project is open source and available under the MIT License.
