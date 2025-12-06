namespace Strategy_Pattern.Strategies;

/// <summary>
/// Concrete Strategy - PayPal Payment Implementation
/// </summary>
public class PayPalPaymentStrategy : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPaymentStrategy(string email)
    {
        _email = email;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount:F2}");
        Console.WriteLine($"PayPal Account: {_email}");
        Console.WriteLine("✓ Payment processed successfully via PayPal\n");
    }
}

