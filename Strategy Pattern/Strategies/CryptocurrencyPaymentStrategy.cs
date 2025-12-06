namespace Strategy_Pattern.Strategies;

/// <summary>
/// Concrete Strategy - Cryptocurrency Payment Implementation
/// </summary>
public class CryptocurrencyPaymentStrategy : IPaymentStrategy
{
    private readonly string _walletAddress;
    private readonly string _cryptocurrencyType;

    public CryptocurrencyPaymentStrategy(string walletAddress, string cryptocurrencyType = "Bitcoin")
    {
        _walletAddress = walletAddress;
        _cryptocurrencyType = cryptocurrencyType;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing {_cryptocurrencyType} payment of ${amount:F2}");
        Console.WriteLine($"Wallet Address: {_walletAddress}");
        Console.WriteLine($"Converting to {_cryptocurrencyType}...");
        Console.WriteLine("✓ Payment processed successfully via Cryptocurrency\n");
    }
}

