using System;


namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user age as an integer
            Console.WriteLine("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // if the user has had duis as a boolean. 
            Console.WriteLine("Have you ever had a DUI? (Enter true or false)");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());

            // get number of speeding tickets, convert to integer
            Console.WriteLine("How many speeding tickets do you have? ");
            int userTickets = Convert.ToInt32(Console.ReadLine());
            
            // check if user is qualified based on current insurance standards. 
            bool isQualified = userAge > 15 && userDUI != true && userTickets <= 3;
            Console.WriteLine("Qualified?\n" + isQualified);
            // keeps the window open until the user closes it. 
            Console.Read();
        }
    }
}
