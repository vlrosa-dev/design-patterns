using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// PRODUTOA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Galaxy";
        }
    }
}