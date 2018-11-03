using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;

namespace MonopolyConsole.ActionCards
{
    class ForcedDeal:Card
    {
        public ForcedDeal()
        {
            Value = 3;
            Name = "Forced Deal";
            Description = "";
        }
    }
}
