using System;


namespace AbstractClassSubmissionAssignment
{
    // create another class called Employee and have it inherit from the Person class.
    public class Employee : Person, IQuittable
    {
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        // have you employee class from the previous drill inherit that interface and implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("This is the quit method.");
        }
    }
}
