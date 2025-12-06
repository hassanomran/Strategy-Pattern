namespace Strategy_Pattern.Strategies;

/// <summary>
/// Concrete Strategy - Bank Transfer Payment Implementation
/// </summary>
public class BankTransferPaymentStrategy : IPaymentStrategy
{
    private readonly string _accountNumber;
    private readonly string _bankName;

    public BankTransferPaymentStrategy(string accountNumber, string bankName)
    {
        _accountNumber = accountNumber;
        _bankName = bankName;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Bank Transfer payment of ${amount:F2}");
        Console.WriteLine($"Bank: {_bankName}");
        Console.WriteLine($"Account Number: {MaskAccountNumber(_accountNumber)}");
        Console.WriteLine("✓ Payment processed successfully via Bank Transfer\n");
    }

    private string MaskAccountNumber(string accountNumber)
    {
        if (accountNumber.Length <= 4)
            return accountNumber;
        
        return "****" + accountNumber.Substring(accountNumber.Length - 4);
    }
}

