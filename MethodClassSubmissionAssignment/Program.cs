using System;


namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class.
            Class1 class1 = new Class1();
            // call the method in the class, passing in two numbers. 
            class1.method(21, 147);
            // call the method in the class, specifying the parameters by name. 
            class1.method(number1: 27, number2: 12);
            Console.ReadLine();

        }
    }
}
