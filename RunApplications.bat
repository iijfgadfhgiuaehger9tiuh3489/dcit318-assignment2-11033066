@echo off
echo ===============================================
echo DCIT 318 Assignment 2 - OOP Demonstrations
echo ===============================================
echo.

REM Check if .NET is installed
dotnet --version >nul 2>&1
if %errorlevel% neq 0 (
    echo ERROR: .NET SDK is not installed or not in PATH
    echo.
    echo Please install .NET 8.0 SDK from:
    echo https://dotnet.microsoft.com/download
    echo.
    pause
    exit /b 1
)

echo .NET SDK version:
dotnet --version
echo.

echo Building all projects...
dotnet build OOPDemonstration.sln
if %errorlevel% neq 0 (
    echo Build failed!
    pause
    exit /b 1
)

echo.
echo ===============================================
echo Choose which application to run:
echo ===============================================
echo 1. Inheritance and Method Overriding
echo 2. Abstract Classes and Methods  
echo 3. Interfaces
echo 4. Run all applications
echo 5. Exit
echo.

:menu
set /p choice="Enter your choice (1-5): "

if "%choice%"=="1" (
    echo.
    echo Running Inheritance App...
    echo ===============================================
    dotnet run --project InheritanceApp
    echo.
    goto menu
)

if "%choice%"=="2" (
    echo.
    echo Running Abstract Class App...
    echo ===============================================
    dotnet run --project AbstractClassApp
    echo.
    goto menu
)

if "%choice%"=="3" (
    echo.
    echo Running Interface App...
    echo ===============================================
    dotnet run --project InterfaceApp
    echo.
    goto menu
)

if "%choice%"=="4" (
    echo.
    echo Running all applications...
    echo.
    echo ===============================================
    echo INHERITANCE AND METHOD OVERRIDING:
    echo ===============================================
    dotnet run --project InheritanceApp
    echo.
    echo ===============================================
    echo ABSTRACT CLASSES AND METHODS:
    echo ===============================================
    dotnet run --project AbstractClassApp
    echo.
    echo ===============================================
    echo INTERFACES:
    echo ===============================================
    dotnet run --project InterfaceApp
    echo.
    goto menu
)

if "%choice%"=="5" (
    echo Goodbye!
    exit /b 0
)

echo Invalid choice. Please enter 1-5.
goto menu
