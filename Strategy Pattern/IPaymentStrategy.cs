namespace Strategy_Pattern;

/// <summary>
/// Strategy Interface - Defines the contract for all payment strategies
/// </summary>
public interface IPaymentStrategy
{
    /// <summary>
    /// Processes a payment with the given amount
    /// </summary>
    /// <param name="amount">The amount to be paid</param>
    void ProcessPayment(decimal amount);
}

