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
            int playerCount = Convert.ToInt32(Console.ReadLine());
            List<Player> players = new List<Player>();
            for (int i = 0; i < playerCount; i++)
            {
                Player newPlayer = new Player();
                Console.WriteLine("Please enter player name");
                newPlayer.Name = Console.ReadLine();
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
            int maxSets = new int();
            foreach (Player player in players)
            {
            }

            Console.Read();
        }
    }


        //2 deal breakers
        //3 debt collectors (force 1 player to pay 5 mil)
        //2 double the rent
        //4 forced deal (swap a property)
        //3 hotel cards
        //3 house cards
        //3 birthday cards
        //3 just say no
        //3 sly deal
        //10 pass go (draw 2 extra)


        //brown: baltic ave and mediterranean ave
        //bold blue: boardwalk and park place
        //dark green: north carolina ave, pacific ave, pennsylvania ave
        //light blue: connecticut ave, oriental ave, vermont ave
        //orange: new york ave, st. james place, tennesee ave
        //magenta: st.charles place, virginia ave, states ave
        //black: short line RR, B*O RR, Reading RR, Pennsylvania RR
        //red: kentucky ave, indiana ave, illinois ave
        //teal: water works, electric co
        //yellow: ventor ave, marvin gardens, atlantic ave

        //11 property wildcards:
        //1 bold blue/ dark green
        //1 light blue/brown
        //2 pure wilds
        //2 orange and magenta
        //1 dark green and RR
        //1 light blue and RR
        //1 utilities and RR
        //2 yellow and red

        //3 wild rent
        //2 dark green/blue
        //2 brown/light blue
        //2 magenta orange
        //2 RR and utilities
        //2 red yellow


        //1 10 million
        //2 5M
        //3 4M
        //3 3M
        //5 2m
        //6 1m



    }
