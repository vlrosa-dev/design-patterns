using System.ComponentModel.DataAnnotations;

namespace Solid.ocp
{
    public class OpenClosed
    {
        
    }

    interface IRemuneravel
    {
        public int Remuneracao();
    }

    class ContratoClt : IRemuneravel
    {
        public int Remuneracao()
        {
            throw new System.NotImplementedException();
        }
    }
    
    class ContratoPj : IRemuneravel
    {
        public int Remuneracao()
        {
            throw new System.NotImplementedException();
        }
    }
    
    class Estagio : IRemuneravel
    {
        public int Remuneracao()
        {
            throw new System.NotImplementedException();
        }
    }

    class FolhaDePagamento
    {
        protected int saldo;

        public void Calcular(IRemuneravel contrato)
        {
            this.saldo = contrato.Remuneracao();
        }
    }
}