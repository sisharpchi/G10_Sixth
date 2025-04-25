namespace _1dars;

public class PaymentFactory
{
    public static IPayment GetPaymentType(string paymentType)
    {
        return paymentType switch
        {
            "Uzum" => new UzumPayment(),
            "Click" => new ClickPayment(),
            "Payme" => new PaymePayment(),
            _ => throw new ArgumentException("Invalid payment type")
        };
    }
}
