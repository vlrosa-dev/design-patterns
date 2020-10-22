using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Client
    {
        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

    }
}
