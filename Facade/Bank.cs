using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Bank
    {
        public bool CheckSaving(Client c, int amount)
        {
            Console.WriteLine($"Checking {c.Name} Savings");
            return new Random().Next(100) < 50 ? true : false;
        }
    }
}
