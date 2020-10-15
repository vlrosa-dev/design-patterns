using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcretesFactory
{
    /// <summary>
    /// CONCRETEFACTORY2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}