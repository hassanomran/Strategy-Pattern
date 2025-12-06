# Strategy Pattern Example in C#

A comprehensive example demonstrating the **Strategy Pattern** design pattern in C# using a payment processing system.

## 📋 Table of Contents

- [Overview](#overview)
- [What is the Strategy Pattern?](#what-is-the-strategy-pattern)
- [Project Structure](#project-structure)
- [How It Works](#how-it-works)
- [Running the Example](#running-the-example)
- [Key Benefits](#key-benefits)
- [When to Use Strategy Pattern](#when-to-use-strategy-pattern)

## 🎯 Overview

This project demonstrates the Strategy Pattern through a payment processing system where different payment methods (Credit Card, PayPal, Bank Transfer, Cryptocurrency) can be selected and used interchangeably at runtime.

## 🔍 What is the Strategy Pattern?

The **Strategy Pattern** is a behavioral design pattern that:
- Defines a family of algorithms
- Encapsulates each algorithm in a separate class
- Makes them interchangeable at runtime

This pattern allows the algorithm to vary independently from the clients that use it.

### Pattern Components

1. **Strategy Interface** (`IPaymentStrategy`): Defines the contract for all payment strategies
2. **Concrete Strategies**: Implementations of different payment methods
   - `CreditCardPaymentStrategy`
   - `PayPalPaymentStrategy`
   - `BankTransferPaymentStrategy`
   - `CryptocurrencyPaymentStrategy`
3. **Context** (`PaymentContext`): Uses the strategy interface to execute payments

## 📁 Project Structure

```
Strategy Pattern/
│
├── Strategies/
│   ├── CreditCardPaymentStrategy.cs
│   ├── PayPalPaymentStrategy.cs
│   ├── BankTransferPaymentStrategy.cs
│   └── CryptocurrencyPaymentStrategy.cs
│
├── PaymentContext.cs          # Context class that uses strategies
├── Program.cs                  # Main program with examples
└── README.md                  # This file
```

## 🔧 How It Works

### 1. Strategy Interface

```csharp
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}
```

### 2. Concrete Strategy Implementation

Each payment method implements the `IPaymentStrategy` interface:

```csharp
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        // Credit card specific payment logic
    }
}
```

### 3. Context Class

The `PaymentContext` class uses the strategy without knowing the concrete implementation:

```csharp
public class PaymentContext
{
    private IPaymentStrategy? _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(decimal amount)
    {
        _paymentStrategy?.ProcessPayment(amount);
    }
}
```

### 4. Usage Example

```csharp
var paymentContext = new PaymentContext();

// Select strategy at runtime
var creditCardStrategy = new CreditCardPaymentStrategy("1234567890123456", "John Doe");
paymentContext.SetPaymentStrategy(creditCardStrategy);
paymentContext.ExecutePayment(150.00m);

// Switch to a different strategy
var payPalStrategy = new PayPalPaymentStrategy("john.doe@example.com");
paymentContext.SetPaymentStrategy(payPalStrategy);
paymentContext.ExecutePayment(250.50m);
```

## 🚀 Running the Example

### Prerequisites

- .NET 8.0 SDK or later

### Steps

1. **Navigate to the project directory:**
   ```bash
   cd "Strategy Pattern"
   ```

2. **Restore dependencies (if needed):**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

### Expected Output

The program will demonstrate:
- Credit Card payment processing
- PayPal payment processing
- Bank Transfer payment processing
- Cryptocurrency payment processing
- Dynamic strategy selection at runtime

## ✨ Key Benefits

1. **Open/Closed Principle**: Add new payment methods without modifying existing code
2. **Single Responsibility**: Each strategy handles one payment method
3. **Runtime Flexibility**: Choose payment method at runtime based on user input or conditions
4. **Easy Testing**: Each strategy can be tested independently
5. **Eliminates Conditional Statements**: No need for if/else or switch statements to choose algorithms
6. **Code Reusability**: Strategies can be reused across different contexts

## 🎓 When to Use Strategy Pattern

Use the Strategy Pattern when:

- ✅ **Multiple classes differ only in their behavior** (Option A from the quiz)
- ✅ **A client needs to choose from multiple algorithms** (Option C from the quiz)
- ✅ You want to avoid conditional statements for algorithm selection
- ✅ You need to switch algorithms at runtime
- ✅ You want to isolate algorithm implementation details from the client code

### Real-World Scenarios

- Payment processing systems (as demonstrated here)
- Sorting algorithms (QuickSort, MergeSort, BubbleSort)
- Compression algorithms (ZIP, RAR, 7Z)
- Validation strategies (Email, Phone, Credit Card validation)
- Discount calculation systems (Percentage, Fixed, Seasonal discounts)

## 📚 Design Principles Applied

- **Open/Closed Principle**: Open for extension (new strategies), closed for modification
- **Dependency Inversion**: Depend on abstractions (`IPaymentStrategy`), not concrete classes
- **Single Responsibility**: Each strategy class has one responsibility

## 🔄 Adding a New Strategy

To add a new payment method:

1. Create a new class implementing `IPaymentStrategy`:
   ```csharp
   public class ApplePayPaymentStrategy : IPaymentStrategy
   {
       public void ProcessPayment(decimal amount)
       {
           // Apple Pay specific logic
       }
   }
   ```

2. Use it in your code:
   ```csharp
   var applePayStrategy = new ApplePayPaymentStrategy();
   paymentContext.SetPaymentStrategy(applePayStrategy);
   paymentContext.ExecutePayment(100.00m);
   ```

No modifications to existing code are required! 🎉

## 📝 Notes

- The Strategy Pattern is particularly useful when you have multiple ways to perform a task and want to choose the approach at runtime
- It promotes code flexibility and maintainability
- It's one of the most commonly used design patterns in software development

## 🤝 Contributing

Feel free to extend this example with additional payment strategies or use cases!

---

**Happy Coding!** 💻

