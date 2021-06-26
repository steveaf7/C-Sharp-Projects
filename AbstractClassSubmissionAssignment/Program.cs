using System;


namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object with the firstName "Sample" and lastName "Student"
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            // call the SayName() method on the object. 
            employee.SayName();
            Console.ReadLine();
        }
    }
}
