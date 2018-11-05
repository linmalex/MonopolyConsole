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
            for (int i = 0; i < player.Hand.Count(); i++)
            {
                string cardName = player.Hand[i].Name;
                int cardValue = player.Hand[i].Value;
                Console.WriteLine("{0}) {1} {2} million dollars", (i + 1), cardName, cardValue);
            }
        }
    }
}
