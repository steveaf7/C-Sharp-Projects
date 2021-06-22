using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // create a one dimensional Array of strings. 
        string[] stringArray = { "Hello", "Welcome", "Hi", "What's up" };
        // ask the user to select an index of the Array and then display the string at that index on the screen.
        Console.WriteLine("Enter an index from 0 to 3");
        int index = Convert.ToInt32(Console.ReadLine());
        // add a message that displays when the user selects an index that doesn't exist
        string result = (index > 3) ? "That index does not exist. " : stringArray[index];
        Console.WriteLine(result);

        // create a one dimensional Array of integers.
        int[] intArray = { 7, 4, 432, 1654, 38 };
        //ask the user to select an index of the Array and then display the string at that index on the screen. 
        Console.WriteLine("Enter an index from 0 to 4");
        index = Convert.ToInt32(Console.ReadLine());
        result = (index > 4) ? "That index does not exist. " : Convert.ToString(intArray[index]);
        Console.WriteLine(result);

        // create a list of strings
        List<string> strList = new List<string>();
        strList.Add("Hello");
        strList.Add("Hi");
        strList.Add("What's up");
        strList.Add("Welcome");
        Console.WriteLine("Enter an index from 0 to 3");
        index = Convert.ToInt32(Console.ReadLine());
        result = (index > 3) ? "That index does not exist. " : strList[index];
        Console.WriteLine(result);
        Console.Read();


    }
}

