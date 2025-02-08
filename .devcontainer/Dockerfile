# Base image with .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Install additional tools or dependencies
RUN apt-get update && apt-get install -y \
    bash \
    git \
    curl \
    && rm -rf /var/lib/apt/lists/*

# Install a .NET global tool (replace `dotnet-ef` with the desired tool)
RUN dotnet tool install -g dotnet-ef

# Add the global .NET tools path to PATH
ENV PATH="$PATH:/root/.dotnet/tools"

# Verify installation
RUN dotnet --info && dotnet tool list -g