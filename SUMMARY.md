# C# Calculator Programs - Summary

## What We Built

I've created two complete C# calculator applications for you:

### 1. Console Calculator (`ConsoleCalculator/`)
- **File**: `Calculator.cs`
- **Type**: Command-line interface
- **Features**: 
  - Basic arithmetic operations (+, -, *, /, %, ^)
  - Error handling for division by zero
  - Input validation
  - Cross-platform compatibility

### 2. GUI Calculator (`GUICalculator/`)
- **File**: `CalculatorGUI.cs`
- **Type**: Windows Forms graphical interface
- **Features**:
  - Modern button-based interface
  - Visual calculator layout
  - Clear and negate functions
  - Error handling with message boxes
  - Professional appearance

## Project Structure
```
/workspace/
├── ConsoleCalculator/
│   ├── Calculator.cs
│   └── Calculator.csproj
├── GUICalculator/
│   ├── CalculatorGUI.cs
│   └── CalculatorGUI.csproj
├── test_calculator.sh
├── README.md
└── SUMMARY.md
```

## How to Use

### Console Calculator
```bash
cd ConsoleCalculator
dotnet run
```

**Example usage:**
```
Enter first number: 10
Enter operation (+, -, *, /, %, ^): +
Enter second number: 5
Result: 10 + 5 = 15
```

### GUI Calculator
```bash
cd GUICalculator
dotnet run
```
*Note: Requires Windows or X11 forwarding on Linux*

## Testing

Run the test script to see all operations in action:
```bash
./test_calculator.sh
```

## Key Features Implemented

1. **Error Handling**: Division by zero, invalid inputs
2. **Input Validation**: Proper number parsing and operation validation
3. **Multiple Operations**: Addition, subtraction, multiplication, division, modulo, power
4. **User-Friendly Interface**: Clear prompts and error messages
5. **Cross-Platform**: Console version works on any .NET-supported platform
6. **Professional Code**: Proper C# conventions, nullable reference types, exception handling

## Technical Details

- **Framework**: .NET 8.0
- **Language**: C# with modern features (switch expressions, nullable reference types)
- **Architecture**: Clean separation of concerns with dedicated calculation methods
- **Error Handling**: Comprehensive exception handling with user-friendly messages

Both calculators are fully functional and ready to use!