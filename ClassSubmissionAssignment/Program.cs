using System;


namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class.
            Class1 class1 = new Class1();
            // have the user enter a number.
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // call the method on that number. Display the output to the screen.
            class1.Divide(number);
            Console.WriteLine("{0} / 2 = {1}", number, class1.Answer);

           
            // run function with 'out' parameters, declare variables inline
            class1.MultiplyBy3and4(out int times3, out int times4, number);
            Console.WriteLine("{0} X 3 = {1}\n{0} X 4 = {2}", number, times3, times4);
            Console.Read();

        }
    }
}
