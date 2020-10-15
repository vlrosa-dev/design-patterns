using AbstractFactory.Interfaces;

namespace AbstractFactory.Client
{
    /// <summary>
    /// CLIENT
    /// </summary>
    public class TelemovelClient
    {
        ISmartPhone SmartPhone;

        INormalPhone NormalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            SmartPhone = telemovelFactory.BuscarSmartPhone();
            NormalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return SmartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return NormalPhone.BuscarDetalhesModelo();
        }
    }
}