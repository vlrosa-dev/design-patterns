using System;
using System.Collections.Generic;
using System.Text;

public class Client
{
    static void Main()
    {

        Person P1 = new Person()
        {
            Age = 18,
            BirthDate = Convert.ToDateTime("2002-01-01"),
            Name = "Roberto",
            Address = new Address("Rua 5")
        };
        Person P2 = P1;
        Person P3 = P1.ShallowCopy();
        Person P4 = P1.Clone();
        Console.WriteLine("Antes da Modificação");
        P1.Print();
        P2.Print();
        P3.Print();
        P4.Print();

        P1.Age = 22;
        Console.WriteLine("Mudou a idade");
        P1.Print();
        P2.Print();
        P3.Print();
        P4.Print();

        P1.Address = new Address("Vila Velha");
        Console.WriteLine("Mudou o endereço (referência)");
        P1.Print();
        P2.Print();
        P3.Print();
        P4.Print();
    }
}
