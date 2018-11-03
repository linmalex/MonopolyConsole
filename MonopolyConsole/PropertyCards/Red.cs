using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class Red:Card
    {
        public Red(string name)
        {
            Value = 3;
            Name = name;
        }
    }
}
