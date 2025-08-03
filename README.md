# DCIT 318 Assignment 2 - Object-Oriented Programming in C#

This repository contains three C# console applications demonstrating different aspects of object-oriented programming:

## Applications

### 1. InheritanceApp - Inheritance and Method Overriding

Demonstrates inheritance and method overriding with:

- Base class `Animal` with virtual method `MakeSound()`
- Derived classes `Dog` and `Cat` that override `MakeSound()`
- Polymorphism demonstration

### 2. AbstractClassApp - Abstract Classes and Methods

Demonstrates abstract classes and methods with:

- Abstract class `Shape` with abstract method `GetArea()`
- Derived classes `Circle` and `Rectangle` implementing `GetArea()`
- Area calculations for different shapes

### 3. InterfaceApp - Interfaces

Demonstrates interfaces with:

- Interface `IMovable` with method `Move()`
- Classes `Car` and `Bicycle` implementing `IMovable`
- Interface polymorphism

## How to Run

### Prerequisites

- .NET 8.0 SDK or later

### Running Individual Applications

#### Option 1: Using Visual Studio

1. Open `OOPDemonstration.sln` in Visual Studio
2. Set the desired project as startup project
3. Press F5 or click Run

#### Option 2: Using Command Line

Navigate to the project folder and run:

**For Inheritance App:**

```bash
cd InheritanceApp
dotnet run
```

**For Abstract Class App:**

```bash
cd AbstractClassApp
dotnet run
```

**For Interface App:**

```bash
cd InterfaceApp
dotnet run
```

#### Option 3: Build and Run All

```bash
# Build all projects
dotnet build OOPDemonstration.sln

# Run each application
dotnet run --project InheritanceApp
dotnet run --project AbstractClassApp
dotnet run --project InterfaceApp
```

## Project Structure

```
dcit318-assignment2-11033066/
├── InheritanceApp/
│   ├── Program.cs
│   └── InheritanceApp.csproj
├── AbstractClassApp/
│   ├── Program.cs
│   └── AbstractClassApp.csproj
├── InterfaceApp/
│   ├── Program.cs
│   └── InterfaceApp.csproj
├── OOPDemonstration.sln
└── README.md
```

## Key Concepts Demonstrated

### Inheritance and Method Overriding

- Virtual methods in base classes
- Method overriding in derived classes
- Polymorphism through inheritance

### Abstract Classes

- Abstract classes that cannot be instantiated
- Abstract methods that must be implemented by derived classes
- Concrete implementations in derived classes

### Interfaces

- Interface contracts that classes must implement
- Multiple implementations of the same interface
- Interface-based polymorphism

## Student Information

Student ID: 11033066
Assignment: DCIT 318 Assignment 2
