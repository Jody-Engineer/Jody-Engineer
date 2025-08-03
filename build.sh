#!/bin/bash

echo "Building C# Calculator..."

# Check if .NET is installed
if ! command -v dotnet &> /dev/null; then
    echo "Error: .NET SDK is not installed. Please install .NET 6.0 or later."
    exit 1
fi

# Build the project
dotnet build

if [ $? -eq 0 ]; then
    echo "Build successful!"
    echo ""
    echo "To run the console calculator:"
    echo "dotnet run --project Calculator.csproj"
    echo ""
    echo "To run the GUI calculator:"
    echo "dotnet run --project CalculatorGUI.csproj"
    echo ""
    echo "Or you can run the compiled executables directly:"
    echo "./bin/Debug/net6.0-windows/Calculator.exe"
    echo "./bin/Debug/net6.0-windows/CalculatorGUI.exe"
else
    echo "Build failed!"
    exit 1
fi