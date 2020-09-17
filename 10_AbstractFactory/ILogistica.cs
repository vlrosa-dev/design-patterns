public interface ILogistica
{
    //Poderiam ter outros metodos relacionados: Preparecargo, TraceRoute...
    public ICargo CreateCargo();
    public ITransport CreateTransport();
}
