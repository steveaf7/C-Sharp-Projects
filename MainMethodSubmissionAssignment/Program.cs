using System;


namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class and call the one method, passing in an integer, display to screen.
            Math math = new Math();
            Console.WriteLine(Math.Operation(20));
            Console.ReadLine();

            // instantiate the class and call the second method, passing in a decimal, display to screen.
            Math math1 = new Math();
            decimal dec = 213.9324m;
            Console.WriteLine(Math.Operation(dec));
            Console.ReadLine();

            // instantiate the class and call the third method, passing in a string that equates to an integer
            // display the results to the screen. 
            Math math2 = new Math();
            string input = "143";
            Console.WriteLine(Math.Operation(input));
            Console.ReadLine();

        }
    }
}
