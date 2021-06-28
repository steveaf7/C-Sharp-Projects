using System;


namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number and assign an amount to it.
            Number number = new Number() { Amount = 345.16m };
            
            //Print this amount to the console. 
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
