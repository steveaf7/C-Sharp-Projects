using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            // add the first card from the deck to the hand
            Hand.Add(Deck.Cards.First());
            // 
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\steve\logs\log.txt", true))
            {
                file.WriteLine(card);
            }
                // remove the card that was just dealt.
            Deck.Cards.RemoveAt(0);
        }
    }
}
