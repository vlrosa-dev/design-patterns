using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcretesFactory
{
    /// <summary>
    /// CONCRETEFACTORY1
    /// </summary>
    public class Nokia : ITelemovel
    {
        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }
    }
}