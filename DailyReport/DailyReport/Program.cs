using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints the messages on separate lines. 
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            // saves the user input as a string at the location studentName
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumberRaw = Console.ReadLine();
            // converts string input to integer
            int pageNumber = Convert.ToInt32(pageNumberRaw);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelpRaw = Console.ReadLine();
            // converts input to boolean for storage.
            bool needHelp = Convert.ToBoolean(needHelpRaw);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedRaw = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursStudiedRaw);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\nHave a Great day!");
            // keeps the window open so the last line ca be read. 
            Console.ReadLine();

            



        }
    }
}
