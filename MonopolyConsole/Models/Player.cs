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
        //properties
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public Table Table { get; set; }
        public List<Card> Bank { get; set; }
        public int CompleteSetCount { get; set; }

        //constructors
        public Player()
        {
            CompleteSetCount = 0;
        }

        //methods
        public void DrawCard(Deck deck, List<Card> hand)
        {
            hand.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }
        public void DepositToBank(Card card) { }
        public void AddToBoard(Card card) { }
        public void PlayToCenter(Card card) { }

        public static void TakeTurn(Player player, Deck deck, List<Card> hand)
        {
            player.DrawCard(deck, hand);
            player.DrawCard(deck, hand);
            Game.ShowHand(player);
            Console.WriteLine("How many cards would you like to play?");
            int cardsToPlay = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cardsToPlay; i++)
            {
                Console.WriteLine("Which card would you like to play? To choose, select the nth card in your hand");
                var nthCard = Convert.ToInt32(Console.ReadLine());
                var cardToPlay = hand[nthCard];
                cardToPlay.Play();
            }
        }
    }
}
