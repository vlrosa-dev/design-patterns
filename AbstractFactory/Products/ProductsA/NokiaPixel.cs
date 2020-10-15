using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// PRODUTOA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia Pixel";
        }
    }
}