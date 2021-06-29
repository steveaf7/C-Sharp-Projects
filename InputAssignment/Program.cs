using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user for a number
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            // log that number to a text file. 
            using (StreamWriter file = new StreamWriter(@"C:\users\steve\log.txt", true))
            {
                file.WriteLine(number);
            }
            // print the text file back to the user. 
            string text = File.ReadAllText(@"C:\users\steve\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
