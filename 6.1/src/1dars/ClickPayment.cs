namespace _1dars;

public class ClickPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Click payment of {amount} was successful.");
    }
}
