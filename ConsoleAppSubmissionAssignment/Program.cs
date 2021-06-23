using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        //Part One
        // A one-dimensional array of strings.
        string[] stringArray = { "String1", "String2", "String3", "String4" };
        // Ask the user to input some text
        Console.WriteLine("Input some text: ");
        string text = Convert.ToString(Console.ReadLine());

        //loop iterates through each string in the array and add the user's text to the end of each string. 
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += text;
        }

        // loop prints off each string in the array on a separate line. 
        foreach (string strng in stringArray)
        {
            Console.WriteLine(strng);
        }

        //Part Two
        // an infinite loop
        bool isTrue = true;
        int infinite = 0;
        while (isTrue)
        {
            Console.WriteLine(infinite);
            infinite++;
            // if you take this out, the loop wiil run indefinitely.
            if (infinite > 10)
            {
                isTrue = false;
            }
        }
        Console.ReadLine();

        //Part Three
        // loop where comparison operator is <
        int number = 0;
        while (number < 5)
        {
            Console.WriteLine(number);
            number++;
        }
        Console.ReadLine();

        //loop where comparison operator is <=
        number = 0;
        while (number <= 5)
        {
            Console.WriteLine(number);
            number++;
        }
        Console.ReadLine();

        // Part Four
        // a list of strings where each item in the list is unique.
        List<string> languages = new List<string>() { "c#", "python", "html", "javascript", "css", "sql" };

        // ask the user to input text to search for in the list.
        Console.WriteLine("Enter a language to search through the list: ");
        string input = Console.ReadLine().ToLower();
        // checks if the user put in text that isn't on the list, 
        if (languages.Contains(input))
        {
            // a loop that iterates through the list and then displays the index that contains matching text on the screen.
            for (int i = 0; i < languages.Count; i++)
            {
                if (languages[i] == input)
                {
                    Console.WriteLine(input + " is at index " + i);
                    // code that stops it from executing once a match has been found. 
                    break;
                }
            }
        }
        // tells the user their item is not in the list.
        else
        {
            Console.WriteLine("Input not found in list. ");
        }
        Console.ReadLine();

        //Part Five
        // a list of strings that has at least two identical strings in the list. 
        List<string> fruits = new List<string> { "apple", "banana", "kiwi", "banana", "pear", "apple" };
        //Ask the user to select text to search for in the list. 
        Console.WriteLine("Type apple, banana, kiwi, or pear: ");
        string fruit = Console.ReadLine().ToLower();
        string sentence = fruit + " is found at index(s): ";
        if (fruits.Contains(fruit))
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == fruit)
                {
                    sentence += i + ", ";
                }
            }
            Console.WriteLine(sentence);
        }
        else
        {
            Console.WriteLine("The item entered is not on the list. ");
        }
        Console.ReadLine();

        // Part Six
        // create a list of strings that has at least two identical strings in the list
        List<string> foodList = new List<string>() { "pizza", "greek", "chipotle", "five guys", "pizza", "chipotle", "pho", "pizza"};
        List<string> newList = new List<string>();
        // create a foreach loop that evaluates each item in the list, and displays a message showing the string and 
        // whether or not is has already appeared in the list. 
        foreach (string food in foodList)
        {
            Console.WriteLine(food + ":" + newList.Contains(food));
            newList.Add(food);
        }
        Console.ReadLine();

    }
}

