using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter a number as a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number as a divisor (leave blank for default = 5): ");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine(Class1.method1(dividend));
            }
            else
            {
                int divisor = Convert.ToInt32(input);
                Console.WriteLine(Class1.method1(dividend, divisor));
            }
            
            Console.Read();
        }
    }
}
