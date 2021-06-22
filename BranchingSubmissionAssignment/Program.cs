using System;


namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            // print welcome message. get package weight from user, convert to integer.
            Console.WriteLine("Welcome to package Express. Please follow the instructions below.\nPackage Weight? ");
            // I used double for more exact math and because the user could enter a number with a decimal
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            // if package weight greater than 50, print message, end program. 
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.\nHave a good day.");
                Console.Read();
            }

            // if package weight not greater than 50, continue program
            else
            {
                // get package width, height and length from user
                Console.WriteLine("Package Width: ");
                double packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Package Height: ");
                double packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Package Length: ");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                // if sum of length, width, and height greater than 50, print message and exit program.
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express.\nHave a good day.");
                    Console.Read();
                }

                // package meets requirements, continue to quote. 
                else
                {
                    double quote = ((packageHeight * packageWidth * packageLength) * packageWeight) / 100;
                    // prints message with calculated quote and formats to two decimal places. 
                    Console.WriteLine("Your estimated total for shipping this package is: $" + String.Format("{0:0.00}", quote));
                    Console.Read();
                }
            }

            
        }
    }
}
