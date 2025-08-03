#!/bin/bash

echo "Installing .NET SDK..."

# Check if running on Linux
if [[ "$OSTYPE" == "linux-gnu"* ]]; then
    echo "Detected Linux system"
    
    # Check if wget is available
    if command -v wget &> /dev/null; then
        echo "Downloading .NET SDK..."
        wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
        sudo dpkg -i packages-microsoft-prod.deb
        rm packages-microsoft-prod.deb
        
        sudo apt-get update
        sudo apt-get install -y apt-transport-https
        sudo apt-get install -y dotnet-sdk-6.0
        
        echo ".NET SDK installation completed!"
    else
        echo "wget not found. Please install wget first:"
        echo "sudo apt-get install wget"
        exit 1
    fi
else
    echo "This script is designed for Linux systems."
    echo "For other operating systems, please visit:"
    echo "https://dotnet.microsoft.com/download"
    exit 1
fi

# Verify installation
if command -v dotnet &> /dev/null; then
    echo "✅ .NET SDK installed successfully!"
    dotnet --version
else
    echo "❌ .NET SDK installation failed."
    exit 1
fi