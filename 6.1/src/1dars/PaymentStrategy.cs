namespace _1dars;

public class PaymentStrategy
{
    private readonly IPayment _payment;
    
    public PaymentStrategy(IPayment payment)
    {
        _payment = payment;
    }

    public void ExecutePayment(decimal amount)
    {
        _payment.Pay(amount);
    }
}
