using System;


namespace WhileStatements
{
    class Program
    {
        static void Main()
        {
            // set bool for getting out of while loop
            bool isCorrect = false;

            while (!isCorrect)
            {
                // ask user for input, convert to integer and save as number
                Console.WriteLine("Guess a Number between 1 and 5?");
                int number = Convert.ToInt32(Console.ReadLine());

                // use switch statement to have a different message for every number
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One is the loneliest number, but not the right one. ");
                        // stops the execution of case testing  
                        break;
                    case 2:
                        Console.WriteLine("Two is for you, but will not get you out of this loop. ");
                        break;
                    case 3:
                        Console.WriteLine("Three is for trees. ");
                        break;
                    case 4:
                        Console.WriteLine("Four is for .NET Core. ");
                        break;
                    case 5:
                        Console.WriteLine("Five is correct! ");
                        // gets us out of the while loop. 
                        isCorrect = true;
                        break;
                }
            }

            // start second guessing game
            Console.WriteLine("Let's play again!");
            Console.WriteLine("Guess a number between 6 and 10?");
            int guess = Convert.ToInt32(Console.ReadLine());
            // when guess is 8, isGuessed is true, and the while loop will not execute again. 
            bool isGuessed = guess == 8;

            // execute a do while loop, this avoids the problem of the while loop not running at all. in case 8 has 
            // already been guessed above and igGuessed is true, the loop will still run once.  
            do
            {
                // what to do for all guesses that are not equal to 8
                if (guess != 8)
                {
                    Console.WriteLine("Nope! try again. ");
                    Console.WriteLine("Guess a number between 6 and 10?");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                // if the user guesses 8
                else
                {
                    Console.WriteLine("8 is Great! Correct.");
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
