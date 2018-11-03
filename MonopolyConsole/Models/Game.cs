using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyConsole.Models
{
    class Game
    {
        public List<Player> Players { get; set; }
        public Discard DiscardPile { get; set; }
        public Deck Deck { get; set; }

        public Game()
        {

        }
    }
}
