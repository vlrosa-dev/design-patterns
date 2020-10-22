using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Credit
    {
        public bool CheckSerasa(Client c, int amount)
        {
            Console.WriteLine($"Checking {c.Name} Name in Serasa");
            return new Random().Next(100) < 50 ? true : false;
        }
    }
}
