using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "jamie";
            //if (name != "Jamie")
            //{
            //    Console.WriteLine("Hey Jamie");
            //}
            //else if (name == "Steve")
            //{
            //    Console.WriteLine("Hey Steve");
            //}
            //else
            //{
            //    Console.WriteLine("You're not Jamie or Steve!");
            //}
            //Console.Read();
            //int age = 21;
            //if (age >= 18)
            //{
            //    Console.WriteLine("You are officially old enough to go to war. ");
            //}
            //if (age >= 21)
            //{
            //    Console.WriteLine("You are officially old enough to have a beer. Are you ready for your first beer?");
            //}
            //Console.Read();

            //int num1 = 7;

            //if (num1 < 18 && ((num1 == 7) || num1 == 2) && ((num1 == 8 && num1 > 20) || (num1 < 20 && num1 > 2)))
            //{
            //    Console.WriteLine("Wow, that was confusing.");
            //}
            int num1 = 12;
            int num2 = 13;
            string result = num1 < num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
