using System;


namespace MathAndComparisonOperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Anonymous Income Comparison Program");

            // get and store information for person 1
            Console.WriteLine("Person 1 \nHourly Rate? ");
            int p1hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p1hoursPerWeek = Convert.ToInt32(Console.ReadLine());

            // get and store information for person 2
            Console.WriteLine("Person 2 \nHourly Rate? ");
            int p2hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p2hoursPerWeek = Convert.ToInt32(Console.ReadLine());

            // calculates annual salarys for person 1 and person 2
            int p1AnnualSalary = p1hourlyRate * p1hoursPerWeek * 52;
            int p2AnnualSalary = p2hourlyRate * p2hoursPerWeek * 52;

            // displays the annual salaries of person 1 and person 2
            Console.WriteLine("Annual Salary of Person 1: \n" + p1AnnualSalary);
            Console.WriteLine("Annual Salary of Person 1: \n" + p2AnnualSalary);

            // checks if person 1 makes more than person 2
            bool isp1SalaryGreater = p1AnnualSalary > p2AnnualSalary; 
            Console.WriteLine("Does person 1 make more money than Person 2? \n" + isp1SalaryGreater);

            // keeps the window open until the user closes it. 
            Console.Read();
        }
    }
}
