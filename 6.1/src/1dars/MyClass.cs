namespace _1dars;

public class MyClass
{
    private static MyClass _instance;
    private static object _lock = new Object();

    private MyClass() { }

    public static MyClass GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            { 
                if (_instance == null)
                {
                    _instance = new MyClass();
                }
            }
        } 
        return _instance;
    }    
}
