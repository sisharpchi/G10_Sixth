// See https://aka.ms/new-console-template for more information
using _1dars;

//List<Thread> threadList = new List<Thread>();

//for (var i = 1; i <= 10; i++)
//{
//    var threadNumber = i;
    
//    Thread thread = new Thread(() =>
//    {
//        Console.WriteLine($"Thread #{threadNumber} ishga tushdi.");
//        var instance = MyClass.GetInstance();
//        Console.WriteLine($"Thread #{threadNumber} obyekti: {instance.GetHashCode()}");
//    });

//    threadList.Add(thread);
//}


//foreach (var thread in threadList)
//{
//    thread.Start();
//}

//foreach (var thread in threadList)
//{
//    thread.Join();
//}

//Console.WriteLine("Barcha threadlar tugadi.");



var type = "Click";

var payment = PaymentFactory.GetPaymentType(type);

var paymentStrategy = new PaymentStrategy(payment);
paymentStrategy.ExecutePayment(1000);

