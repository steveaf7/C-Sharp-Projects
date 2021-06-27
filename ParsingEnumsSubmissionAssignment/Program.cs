﻿using System;


namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current day of the week: ");
            // assign the value to a variable of that enum data type you just created. 
            string input = Console.ReadLine();
            try
            {
                // converts input into an enum (if it corresponds with an element in enum)
                Enum.Parse(typeof(DaysOfTheWeek), input);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week. ");
            }

            Console.ReadLine();

        }
        // create an enum for days of the week. 
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
