using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exemplo Singleton.");

        SingletonBalancer b1 = SingletonBalancer.GetInstance();
        SingletonBalancer b2 = SingletonBalancer.GetInstance();
        SingletonBalancer b3 = SingletonBalancer.GetInstance();
        SingletonBalancer b4 = SingletonBalancer.GetInstance();
        SingletonBalancer b5 = SingletonBalancer.GetInstance();
        SingletonBalancer b6 = SingletonBalancer.GetInstance();

        var igual = (b1 == b2 && b3 == b4 && b5 == b6);

        Console.WriteLine(igual);
        
        Console.WriteLine(b1.GetServer());
        Console.WriteLine(b2.GetServer());
        Console.WriteLine(b3.GetServer());
        Console.WriteLine(b4.GetServer());
        Console.WriteLine(b5.GetServer());
        Console.WriteLine(b6.GetServer());
        try
        {
            Console.WriteLine(b6.GetServer());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }        
    }
}
