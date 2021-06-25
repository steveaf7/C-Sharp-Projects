﻿using System;


namespace MethodsAndObjectsSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student"
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            // Call the superclass method SayName() on the Employee object. 
            employee.SayName();
            Console.ReadLine();
        }
    }
}
