using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.ActionCards;

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
                new PassGo()
            };
        }
        
    }
}
