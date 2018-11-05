using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.ActionCards;
using MonopolyConsole.PropertyCards;

namespace MonopolyConsole.Models
{
    class Set
    {
        public List<PropertyCard> PropertySet { get; set; }
        public bool Complete { get; set; }
    }
}
