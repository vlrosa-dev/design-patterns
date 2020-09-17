public class LogisticaMaritima : ILogistica
{
    public ICargo CreateCargo()
    {
        return new CargoContainer();
    }

    public ITransport CreateTransport()
    {
        return new TransportShip();
    }
}
