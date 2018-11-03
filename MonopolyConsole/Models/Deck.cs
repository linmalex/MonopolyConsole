﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.ActionCards;
using MonopolyConsole.PropertyCards;
using MonopolyConsole.PropertyWildcards;
using MonopolyConsole.RentCards;

namespace MonopolyConsole.Models
{
    class Deck
    {
        public List<Card> DeckCards { get; set; }


        public Deck()
        {
            DeckCards = new List<Card>()
            {
                new DealBreaker(),
                new DealBreaker(),
                new DebtCollector(),
                new DebtCollector(),
                new DebtCollector(),
                new DoubleRent(),
                new DoubleRent(),
                new ForcedDeal(),
                new ForcedDeal(),
                new ForcedDeal(),
                new Hotel(),
                new Hotel(),
                new Hotel(),
                new House(),
                new House(),
                new House(),
                new ItsMyBirthday(),
                new ItsMyBirthday(),
                new ItsMyBirthday(),
                new JustSayNo(),
                new JustSayNo(),
                new JustSayNo(),
                new SlyDeal(),
                new SlyDeal(),
                new SlyDeal(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new PassGo(),
                new Brown("Baltic Ave"),
                new Brown("Mediterranean Ave"),
                new DarkBlue("Boardwalk"),
                new DarkBlue("Park Place"),
                new Green("North Carolina Ave"),
                new Green("Pacific Ave"),
                new Green("Pennsylvania Ave"),
                new LightBlue("Connecticut Ave"),
                new LightBlue("Oriental Ave"),
                new LightBlue("Vermont Ave"),
                new Orange("New York Ave"),
                new Orange("St. James Place"),
                new Orange("Tennessee Ave"),
                new Magenta("St. Charles Place"),
                new Magenta("Virginia Ave"),
                new Magenta("States Ave"),
                new Railroad("Short Line"),
                new Railroad("B & O Railroad"),
                new Railroad("Reading Railroad"),
                new Railroad("Pennsylvania Railroad"),
                new Red("Kentucky Ave"),
                new Red ("Indiana Ave"),
                new Red ("Illinois Ave"),
                new Utility("Water Works"),
                new Utility("Electric Company"),
                new Yellow("Ventnor Ave"),
                new Yellow("Marvin Gardens"),
                new Yellow("Atlantic Ave"),
                new BlueGreen(),
                new BrownLightBlue(),
                new TotalWild(),
                new TotalWild(),
                new OrangeMagenta(),
                new OrangeMagenta(),
                new GreenRailroad(),
                new LightBlueRailroad(),
                new RailroadUtility(),
                new YellowRed(),
                new YellowRed(),
                new WildRent(),
                new WildRent(),
                new WildRent(),
                new GreenDarkBlueRent(),
                new GreenDarkBlueRent(),
                new BrownLightBlueRent(),
                new BrownLightBlueRent(),
                new OrangeMagentaRent(),
                new OrangeMagentaRent(),
                new UtilityRailroadRent(),
                new UtilityRailroadRent(),
                new RedYellowRent(),
                new RedYellowRent(),
                new MoneyCard(10,"10 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(1,"1 Million"),
                new MoneyCard(2,"2 Million"),
                new MoneyCard(2,"2 Million"),
                new MoneyCard(2,"2 Million"),
                new MoneyCard(2,"2 Million"),
                new MoneyCard(2,"2 Million"),
                new MoneyCard(3,"3 Million"),
                new MoneyCard(3,"3 Million"),
                new MoneyCard(3,"3 Million"),
                new MoneyCard(4,"4 Million"),
                new MoneyCard(4,"4 Million"),
                new MoneyCard(4,"4 Million"),
                new MoneyCard(5,"5 Million"),
                new MoneyCard(5,"5 Million")
            };
        }
        
    }
}
