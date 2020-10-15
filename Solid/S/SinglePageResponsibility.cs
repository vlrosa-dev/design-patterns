namespace Solid.srp
{
    public class SinglePageResponsibility
    {
        /*
         PRINCIPIO DA RESPONSABILIDADE UNICA
         - A CLASSE NAO PODE TER N RESPONSABILIDADES.
         - DEVE RESTRINGIR SUAS RESPONSABILIDADE PARA MELHOR MANUTENCAO DE CODIGO OU QUEBRA.
        */
    }

    class Order
    {
        public void CalculateTotalSum()
        {
            
        }

        public void GetItems()
        {
            
        }

        public void GetItemCount()
        {
            
        }

        public void AddItem()
        {
            
        }
        
    }

    class OrderRepository
    {
        public void Load()
        {
            
        }

        public void Save()
        {
            
        }
        
        public void Update()
        {
            
        }
        
        public void Delete()
        {
            
        }
    }

    class OrderViewer
    {
        public void PrintOrder()
        {
            
        }

        public void ShowOrder()
        {
            
        }
    }

}