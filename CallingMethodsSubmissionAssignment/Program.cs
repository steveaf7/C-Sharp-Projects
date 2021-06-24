using System;


namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what number they want to do the math operations on. 
            Console.WriteLine("Enter a number to perform math operations on: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // call each method in turn passing the user input to the method. 
            // Display the returned integer to the screen. 
            Console.WriteLine(number + " - 20 = " + Math.Subtract20(number));
            Console.WriteLine(number + " X 500 = " + Math.Times500(number));
            Console.WriteLine(number + " / 50 = " + Math.DivideBy50(number));
            // keep the window open until the user closes it. 
            Console.ReadLine();
        }
    }
}
