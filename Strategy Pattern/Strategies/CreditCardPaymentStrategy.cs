namespace Strategy_Pattern.Strategies;

/// <summary>
/// Concrete Strategy - Credit Card Payment Implementation
/// </summary>
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    private readonly string _cardNumber;
    private readonly string _cardHolderName;

    public CreditCardPaymentStrategy(string cardNumber, string cardHolderName)
    {
        _cardNumber = cardNumber;
        _cardHolderName = cardHolderName;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Credit Card payment of ${amount:F2}");
        Console.WriteLine($"Card Number: {MaskCardNumber(_cardNumber)}");
        Console.WriteLine($"Card Holder: {_cardHolderName}");
        Console.WriteLine("✓ Payment processed successfully via Credit Card\n");
    }

    private string MaskCardNumber(string cardNumber)
    {
        if (cardNumber.Length <= 4)
            return cardNumber;
        
        return "****-****-****-" + cardNumber.Substring(cardNumber.Length - 4);
    }
}

