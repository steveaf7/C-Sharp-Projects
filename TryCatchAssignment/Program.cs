using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for their age
            bool validAnswer = false;
            int age = 0;

            while (!validAnswer || age <= 0)
            {
                try
                {
                    Console.WriteLine("enter your age: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                    if (age <= 0)
                    {
                        throw new NegativeOrZeroException();
                    }
                }
                catch (NegativeOrZeroException)
                {
                    Console.WriteLine("Please enter a positive integer. ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error occured. Contact your system administrator.");
                    Console.ReadLine();
                }

            }
               
            // display the year the user was born
            Console.WriteLine("You were born in {0}", 2021 - age);
            Console.ReadLine();



        }
    }
}
