using System;

namespace _10_AbstractFactory
{
    public class TransportTruck : ITransport
    {
        public void Deliver(ICargo Cargo)
        {
            Console.WriteLine(
                $"{this.GetType().Name} entregou uma {Cargo.GetType().Name}");
            Cargo.Open();
        }
    }
}
