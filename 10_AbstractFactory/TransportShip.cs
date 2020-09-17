using System;

public class TransportShip : ITransport
{
    public void Deliver(ICargo Cargo)
    {
        Console.WriteLine(
            $"{this.GetType().Name} entregou uma {Cargo.GetType().Name}");
        Cargo.Open();
    }
}
