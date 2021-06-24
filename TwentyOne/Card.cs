using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{   // a class is just a model it's a design for an object
    public class Card
    {
        // the card class has a property of data type string called suit, you can get this property or set this property.
        // public means it's accessible to other parts of the program. 
        // The constructor method name is always the name of the class that's how C# knows it's a constructor. 
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
