using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Factory
{
    public class Program
    {
        static void Main()
        {
            CardHolder holder = null;

            holder = new PlatinumHolder();
            holder.Card = holder.GetCard();

            holder.PayAccount(5000);
            holder.PayAccount(777);

            Console.WriteLine(holder.Card.AccountBalance);
            Console.WriteLine(holder.Card.GetType());
        }
    }
}
