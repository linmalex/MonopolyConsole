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

        public static void ShowHand(Player player)
        {
            Console.WriteLine("{0}, you have the following cards in your hand", player.Name);
            foreach (Card card in player.Hand)
            {
                Console.WriteLine(card.Name + " " + card.Value);
            }
        }
    }
}
