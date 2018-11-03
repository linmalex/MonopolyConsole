using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class Utility: PropertyCard
    {
        public Utility(string name)
        {
            Value = 2;
            Name = name;
        }
    }
}
