using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// PRODUTOB1
    /// </summary>
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia 1600";
        }
    }
}