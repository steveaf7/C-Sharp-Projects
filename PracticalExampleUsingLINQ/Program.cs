using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticalExampleUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // specify the data source.
            string[] students = new string[] { "Lacey", "Trisha", "Gavin", "Josh", "Jon", "Landon", "Kyndreshia" };

            //Define the query expression.
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 6
                select student;

            //Execute the query.
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }
            Console.ReadLine();
        }
    }
}
