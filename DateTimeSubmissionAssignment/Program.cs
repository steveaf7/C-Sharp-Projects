using System;


namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //print the current date and time to the console.
            Console.WriteLine(DateTime.Now);
            // ask the user for a number. 
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // print to the console the exact time it will be in 'number' hours.
            Console.WriteLine(DateTime.Now.AddHours(number));
            Console.ReadLine();
        }
    }
}
