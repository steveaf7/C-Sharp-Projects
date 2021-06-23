using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // create a list of integers
        List<int> intList = new List<int> { 2, 45, 62, 1500, 13 };

        // put the loop in a try/catch block. 
        try
        {
            // ask the user for a number to divide each number in the list by.
            Console.WriteLine("Enter a number to divide by: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            // Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result. 
            foreach (int number in intList)
            {
                Console.WriteLine(number / divisor);
            }
        }
        // in case the user enters a zero to divide by
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // in the case that the user enters a string instead of an integer
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // to account for possible unknown errors. 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // make program print a message that lets you know that the program has emerged from the try/catch block
        Console.WriteLine("Program has emerged from try/catch block.");
        Console.Read();
    }
    
}

