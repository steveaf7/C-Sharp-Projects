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
            // converts string input to integer
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // converts input to boolean for storage.
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\nHave a Great day!");
            // keeps the window open so the last line ca be read. 
            Console.ReadLine();

            



        }
    }
}
