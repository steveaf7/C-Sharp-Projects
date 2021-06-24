using System;


namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            Class1 class1 = new Class1();

            // ask the user to input two numbers, one at a time.
            Console.WriteLine("Enter a number as a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            // let them know they need not enter anything for the second number
            Console.WriteLine("Enter a number as a divisor (leave blank for default = 5): ");
            string input = Console.ReadLine();

            // call the method in the class, passing in the one or two numbers entered. 
            // if input is blank, calls the method with one argument
            // else, converts input to integer, and calls the method specifying two arguments
            if (input == "")
            {
                Console.WriteLine(dividend + " /  5 = " + class1.method1(dividend));
            }
            else
            {
                int divisor = Convert.ToInt32(input);
                Console.WriteLine("{0} / {1} = {2}", dividend, divisor, class1.method1(dividend, divisor));
            }

            Console.Read();
        }
    }
}
