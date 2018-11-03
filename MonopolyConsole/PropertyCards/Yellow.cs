using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class Yellow: PropertyCard
    {
        public Yellow(string name)
        {
            Value = 3;
            Name = name;
        }
    }
}
