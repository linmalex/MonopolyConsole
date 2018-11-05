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
            Bank = new List<Card>();
        }

        //methods
        public void DrawCard(Deck deck, List<Card> hand)
        {
            hand.Add(deck.Cards[0]);
            deck.Cards.RemoveAt(0);
        }

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
                var nthCard = Convert.ToInt32(Console.ReadLine()) - 1;
                var cardToPlay = hand[nthCard];
                player.PlayCard(cardToPlay, player);
                player.Hand.RemoveAt(nthCard);
                
            }
            int bankTotal = Player.BankTotal(player.Bank);
            Console.WriteLine("You have {0} million dollars in the bank", bankTotal);
        }

        public void PlayCard(Card card, Player player)
        {
            var cardType = card.GetType().Name;
            if (cardType == "MoneyCard")
            {
                player.Bank.Add(card);
            }
        }

        public static int BankTotal(List<Card> hand)
        {
            int bankTotal = 0;
            foreach (Card card in hand)
            {
                bankTotal += card.Value;
            }
            return bankTotal;
        }
    }
}
