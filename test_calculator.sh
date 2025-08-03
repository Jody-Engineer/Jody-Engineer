#!/bin/bash

echo "Testing C# Console Calculator"
echo "============================="

cd ConsoleCalculator

# Test 1: Addition
echo -e "\nTest 1: Addition (10 + 5)"
echo -e "10\n+\n5\nexit" | dotnet run

# Test 2: Subtraction
echo -e "\nTest 2: Subtraction (15 - 7)"
echo -e "15\n-\n7\nexit" | dotnet run

# Test 3: Multiplication
echo -e "\nTest 3: Multiplication (6 * 8)"
echo -e "6\n*\n8\nexit" | dotnet run

# Test 4: Division
echo -e "\nTest 4: Division (20 / 4)"
echo -e "20\n/\n4\nexit" | dotnet run

# Test 5: Power
echo -e "\nTest 5: Power (2 ^ 10)"
echo -e "2\n^\n10\nexit" | dotnet run

# Test 6: Modulo
echo -e "\nTest 6: Modulo (17 % 5)"
echo -e "17\n%\n5\nexit" | dotnet run

echo -e "\nAll tests completed!"