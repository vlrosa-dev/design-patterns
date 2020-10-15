namespace AbstractFactory.Interfaces
{
    /// <summary>
    /// ABSTRACT
    /// </summary>
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();

        INormalPhone BuscarNormalPhone();
    }
}