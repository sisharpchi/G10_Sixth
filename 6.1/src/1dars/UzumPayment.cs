namespace _1dars;

public class UzumPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Uzum payment of {amount} was successful.");
    }
}
