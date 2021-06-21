using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            // takes an input from the user, multiplies it by 50, then prints the result to the console. 
            Console.WriteLine("Enter a number to be multiplied by 50: ");
            // converts user input to integer, than multiplies it by 50 and saves the result as an integer.
            int times50 = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine("X 50 = " + times50);

            // takes an input from the user, adds 25 to it, then prints the result to the console. 
            Console.WriteLine("Enter a number to add 25 to: ");
            int plus25 = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(" + 25 = " + plus25);

            // takes an input from the user, divides it by 12.5, then prints the results to the console. 
            Console.WriteLine("Enter a number and I'll divide it by 12.5: ");
            // takes the user input, converts it to a double, divides by 12.5 and saves it as a double
            double divided = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine(" / 12.5 = " + divided);

            // takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Enter a number and we'll see if it's greater than 50: ");
            bool greaterThan50 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("is greater than 50 = " + greaterThan50);

            // takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Enter a number we'll get the remainder after dividing by 7: ");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(" % 7 = " + remainder);
            // prevents the console window from closing until the user closes it. 
            Console.Read();


        }
    }
}
