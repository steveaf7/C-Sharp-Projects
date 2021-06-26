using System;


namespace AbstractClassSubmissionAssignment
{
    // create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
