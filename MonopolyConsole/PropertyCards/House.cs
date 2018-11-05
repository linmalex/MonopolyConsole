using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class House:PropertyCard
    {
        public House()
        {
            Value = 3;
            Name = "House";
            Description = "";
        }
    }
}
