using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // constructors always go at the top of the class, before properties. 
        // the constructor name is always the same as the class it is in. 
        public Deck()
        {
            // this is referring to the property of the class, that's why we dont put a data type or give a variable name
            // instantiate property Cards as an empty list of cards. 
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
 


        }

        // a deck is a collection of cards
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
            return;
        }
    }
}
