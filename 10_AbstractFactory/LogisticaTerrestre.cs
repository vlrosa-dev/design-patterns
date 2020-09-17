public class LogisticaTerrestre : ILogistica
{
    public ICargo CreateCargo()
    {
        return new CargoBox();
    }

    public ITransport CreateTransport()
    {
        return new TransportTruck();
    }
}
