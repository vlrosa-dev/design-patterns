using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using _09_Factory.ConcreteCreator;
using _09_Factory.Creator;
using _09_Factory.Product;

namespace _09_Factory
{
    public class Program
    {
        static void Main()
        {
            CartaoFactory cartaoFactory = null;
            Console.Write("Digite o tipo de cartão que gostaria de obter:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                
                case "titanium":
                    cartaoFactory = new TitaniumFactory(10000, 500);
                    break;
                
                case "platinum":
                    cartaoFactory = new PlatinumFactory(20000, 1000);
                    break;
                
                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine("\n Detalhes do seu cartao estão abaixo:\n");
            Console.WriteLine($"Tipo de cartao: {cartaoCredito.TipoCartao} \nCredito Limite: {cartaoCredito.LimiteCredito} \nCobranca Anual: {cartaoCredito.CobrancaAnual}");
            Console.ReadKey();
        }
    }
}
