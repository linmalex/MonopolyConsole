using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.PropertyCards
{
    class DarkBlue:Card
    {
        public DarkBlue(string name)
        {
            Value = 4;
            Name = name;
            Description = "";
        }
    }
}
