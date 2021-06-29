using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        // creating a dictionary of all our cards and their values, 
        // when you know something is only going to be used within a class, mark it private, 
        // if it's public and someone later on wanted to use that same name, it could cause a conflict. 
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        { 
            // how many cards in the hand are aces
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // create an array of possible results, we can have as many results as there are aces plus one. 
            int[] result = new int[aceCount + 1];
            // adds the result if Ace is counted as a 1
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            // one line if statement does not need curly brackets. 
            // if the length of the result is 1, there are no aces, and only one possible result, so we can return the result at this point. 
            if (result.Length == 1) return result;
            
            for (int i = 1; i < result.Length; i++)
            {
                // this adds ten to the value of the hand, as if we were counting the ace as 11
                value += i * 10;
                // adds the new value to the list of possible results. 
                result[i] = value;
            }
            return result;

        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            // take the highest possible value for comparison. 
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
                
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
