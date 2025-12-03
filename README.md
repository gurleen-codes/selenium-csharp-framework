# Selenium C# Automation Testing

A simple test automation project using C#, Selenium WebDriver, and the Page Object Model pattern.

## What It Does

Automates login tests for [SauceDemo](https://www.saucedemo.com/) - a practice e-commerce site.

## Tech Used

- C# & .NET 10.0
- Selenium WebDriver
- NUnit testing framework
- Page Object Model design

## Setup & Run
```bash
# Clone and navigate to project
cd SauceDemoTests

# Restore packages
dotnet restore

# Run tests
dotnet test
```

## Project Structure
```
├── Pages/      # Page objects
├── Tests/      # Test cases
└── Utilities/  # Helper classes
```

## Current Tests

- ✅ Valid login
- ✅ Invalid login with error validation

## Learning Goals

Building this to improve my C# and Selenium skills for QA automation roles.