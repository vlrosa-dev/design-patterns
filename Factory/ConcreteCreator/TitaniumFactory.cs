using _09_Factory.ConcreteProduct;
using _09_Factory.Creator;
using _09_Factory.Product;

namespace _09_Factory.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public TitaniumFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoTitanium(_limiteCredito, _cobrancaAnual);
        }
    }
}