using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class PropertyCard:Card
    {
        public bool CompleteStatus { get; set; }
        public int CompleteCount { get; set; }
    }
}
