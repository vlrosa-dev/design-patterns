using System;

class Program
{
    static void Main(string[] args)
    {
        ILogistica logistica = new LogisticaMaritima();

        ICargo cargo = logistica.CreateCargo();
        ITransport transport = logistica.CreateTransport();

        transport.Deliver(cargo);

        Console.WriteLine("-------------------------------------------------------------------------------");
    }
}

