namespace Strategy_Pattern;

/// <summary>
/// Context Class - Uses the Strategy to process payments
/// The context doesn't know the concrete implementation, only the interface
/// </summary>
public class PaymentContext
{
    private IPaymentStrategy? _paymentStrategy;

    /// <summary>
    /// Sets the payment strategy at runtime
    /// </summary>
    /// <param name="paymentStrategy">The payment strategy to use</param>
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    /// <summary>
    /// Executes the payment using the current strategy
    /// </summary>
    /// <param name="amount">The amount to be paid</param>
    public void ExecutePayment(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            throw new InvalidOperationException("Payment strategy has not been set.");
        }

        _paymentStrategy.ProcessPayment(amount);
    }
}

