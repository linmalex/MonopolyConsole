using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.ActionCards;

namespace MonopolyConsole.Models
{
    class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> Table { get; set; }
        public List<Card> Bank { get; set; }

        public void DepositToBank(Card card) { }
        public void AddToBoard(Card card) { }
        public void PlayToCenter(Card card) { }
    }
}
