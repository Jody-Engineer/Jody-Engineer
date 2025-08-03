#!/bin/bash

echo "C# Calculator Compilation Script"
echo "================================"

# Function to check if command exists
command_exists() {
    command -v "$1" >/dev/null 2>&1
}

# Try different C# compilers
if command_exists dotnet; then
    echo "✅ Found .NET SDK"
    echo "Building with dotnet..."
    
    # Try to build the simple calculator first
    if dotnet build SimpleCalculator.csproj; then
        echo "✅ Simple calculator built successfully!"
        echo "Run with: dotnet run --project SimpleCalculator.csproj"
    else
        echo "❌ Simple calculator build failed"
    fi
    
    # Try to build the full project
    if dotnet build Calculator.csproj; then
        echo "✅ Full calculator project built successfully!"
        echo "Run console version: dotnet run --project Calculator.csproj"
        echo "Run GUI version: dotnet run --project CalculatorGUI.csproj"
    else
        echo "❌ Full project build failed"
    fi

elif command_exists mcs; then
    echo "✅ Found Mono C# compiler"
    echo "Compiling SimpleCalculator.cs..."
    
    if mcs SimpleCalculator.cs -out:SimpleCalculator.exe; then
        echo "✅ Compilation successful!"
        echo "Run with: mono SimpleCalculator.exe"
    else
        echo "❌ Compilation failed"
    fi

elif command_exists csc; then
    echo "✅ Found Microsoft C# compiler"
    echo "Compiling SimpleCalculator.cs..."
    
    if csc SimpleCalculator.cs -out:SimpleCalculator.exe; then
        echo "✅ Compilation successful!"
        echo "Run with: ./SimpleCalculator.exe"
    else
        echo "❌ Compilation failed"
    fi

else
    echo "❌ No C# compiler found"
    echo ""
    echo "To install .NET SDK:"
    echo "1. Run: ./install-dotnet.sh"
    echo "2. Or visit: https://dotnet.microsoft.com/download"
    echo ""
    echo "To install Mono:"
    echo "sudo apt-get install mono-complete"
    echo ""
    echo "To install Microsoft C# compiler:"
    echo "Visit: https://docs.microsoft.com/en-us/dotnet/csharp/"
fi

echo ""
echo "Available calculator files:"
echo "- SimpleCalculator.cs (console only, basic operations)"
echo "- Calculator.cs (console, advanced operations)"
echo "- CalculatorGUI.cs (GUI version, requires Windows Forms)"