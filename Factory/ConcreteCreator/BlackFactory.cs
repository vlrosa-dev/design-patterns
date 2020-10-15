using _09_Factory.ConcreteProduct;
using _09_Factory.Creator;
using _09_Factory.Product;

namespace _09_Factory.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public BlackFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(_limiteCredito, _cobrancaAnual);
        }
    }
}