using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// PRODUTOB2
    /// </summary>
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Guru";
        }
    }
}