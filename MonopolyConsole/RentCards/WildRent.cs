using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.RentCards
{
    class WildRent:Card
    {
        public WildRent()
        {
            Value = 3;
            Name = "Wild Rent";
        }
    }
}
