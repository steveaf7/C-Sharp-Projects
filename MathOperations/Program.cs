using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;
            int quotient = number1 / number2;
            Console.WriteLine("Sum: " + sum + "\nDifference: " + difference + "\nProduct: " + product + "\nQuotient: " + quotient);
            Console.ReadLine();
        }
    }
}
