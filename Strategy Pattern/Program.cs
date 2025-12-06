using Strategy_Pattern;
using Strategy_Pattern.Strategies;

namespace Strategy_Pattern;

/// <summary>
/// Strategy Pattern Example
/// 
/// The Strategy Pattern defines a family of algorithms, encapsulates each one,
/// and makes them interchangeable. Strategy lets the algorithm vary independently
/// from clients that use it.
/// 
/// Use Case: When you have multiple ways (algorithms) to perform a task and
/// you want to choose the algorithm at runtime.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Strategy Pattern Example: Payment Processing ===\n");

        // Create a payment context
        var paymentContext = new PaymentContext();

        // Example 1: Credit Card Payment
        Console.WriteLine("--- Example 1: Credit Card Payment ---");
        var creditCardStrategy = new CreditCardPaymentStrategy("1234567890123456", "John Doe");
        paymentContext.SetPaymentStrategy(creditCardStrategy);
        paymentContext.ExecutePayment(150.00m);

        // Example 2: PayPal Payment
        Console.WriteLine("--- Example 2: PayPal Payment ---");
        var payPalStrategy = new PayPalPaymentStrategy("john.doe@example.com");
        paymentContext.SetPaymentStrategy(payPalStrategy);
        paymentContext.ExecutePayment(250.50m);

        // Example 3: Bank Transfer Payment
        Console.WriteLine("--- Example 3: Bank Transfer Payment ---");
        var bankTransferStrategy = new BankTransferPaymentStrategy("9876543210", "Chase Bank");
        paymentContext.SetPaymentStrategy(bankTransferStrategy);
        paymentContext.ExecutePayment(500.00m);

        // Example 4: Cryptocurrency Payment
        Console.WriteLine("--- Example 4: Cryptocurrency Payment ---");
        var cryptoStrategy = new CryptocurrencyPaymentStrategy("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa", "Bitcoin");
        paymentContext.SetPaymentStrategy(cryptoStrategy);
        paymentContext.ExecutePayment(1000.00m);

        // Example 5: Dynamic Strategy Selection (User Choice Simulation)
        Console.WriteLine("--- Example 5: Dynamic Strategy Selection ---");
        Console.WriteLine("Simulating user selecting payment method at runtime...\n");
        
        // Simulate different user choices
        var strategies = new Dictionary<string, IPaymentStrategy>
        {
            { "1", new CreditCardPaymentStrategy("5555555555554444", "Jane Smith") },
            { "2", new PayPalPaymentStrategy("jane.smith@example.com") },
            { "3", new BankTransferPaymentStrategy("123456789", "Wells Fargo") },
            { "4", new CryptocurrencyPaymentStrategy("0x742d35Cc6634C0532925a3b844Bc9e7595f0bEb", "Ethereum") }
        };

        // Process payments with different strategies
        foreach (var strategy in strategies)
        {
            paymentContext.SetPaymentStrategy(strategy.Value);
            paymentContext.ExecutePayment(75.00m);
        }

        Console.WriteLine("\n=== Key Benefits of Strategy Pattern ===");
        Console.WriteLine("1. Open/Closed Principle: Add new payment methods without modifying existing code");
        Console.WriteLine("2. Single Responsibility: Each strategy handles one payment method");
        Console.WriteLine("3. Runtime Flexibility: Choose payment method at runtime");
        Console.WriteLine("4. Easy Testing: Each strategy can be tested independently");
        Console.WriteLine("5. Eliminates conditional statements: No need for if/else or switch statements");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
