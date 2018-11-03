using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class Brown : PropertyCard
    {
        public Brown(string name)
        {
            Value = 1;
            Name = name;
            Description = "";
        }
    }
}
