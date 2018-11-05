using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;
using MonopolyConsole.ActionCards;

namespace MonopolyConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //get the deck
            Deck deck = new Deck();
            deck = Deck.Shuffle(deck);

            //add players
            Console.WriteLine("How many players?");
            //int playerCount = Convert.ToInt32(Console.ReadLine());
            //PLACEHOLDER TO AVOID HAVING TO TYPE THIS IN EVERY TIME
            int playerCount = 2;
            List<Player> players = new List<Player>();
            for (int i = 0; i < playerCount; i++)
            {
                Player newPlayer = new Player();
                Console.WriteLine("Please enter player name");
                //newPlayer.Name = Console.ReadLine();
                newPlayer.Name = ("Player "+ i);
                players.Add(newPlayer);
            }

            //deal hands to player
            foreach (Player player in players)
            {
                List<Card> playerHand = new List<Card>();
                playerHand = Deck.Deal(deck);
                player.Hand = playerHand;
            }

            //set winning conditions
            //game play ends when one player has three or more complete sets
            List<Player> maxSets = players.Where(player => player.CompleteSetCount >= 3).ToList<Player>();

            //PLAY GAME 
            while (maxSets.Count() == 0)
            {
                //define a player turn
                for (int i = 0; i < playerCount; i++)
                {
                    var activePlayer = players[i];
                    Player.TakeTurn(activePlayer, deck, activePlayer.Hand);
                }
            }

            Console.Read();
        }
    }
}
