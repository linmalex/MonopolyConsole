using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.ActionCards
{
    class DebtCollector:Card
    {
        public DebtCollector()
        {
            Value = 3;
            Name = "Debt Collector";
            Description = "";
        }
    }
}
