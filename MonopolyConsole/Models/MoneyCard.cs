using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.Models
{
    class MoneyCard:Card
    {
        public MoneyCard(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
