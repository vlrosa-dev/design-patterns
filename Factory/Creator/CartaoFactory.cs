using _09_Factory.Product;

namespace _09_Factory.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}