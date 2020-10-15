using _09_Factory.ConcreteProduct;
using _09_Factory.Creator;
using _09_Factory.Product;

namespace _09_Factory.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}