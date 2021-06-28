using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{   // a class is just a model it's a design for an object
    public struct Card
    {
        // the card class has a property of data type string called suit, you can get this property or set this property.
        // public means it's accessible to other parts of the program. 
        

        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face 
    { 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King, 
        Ace
    }

}
