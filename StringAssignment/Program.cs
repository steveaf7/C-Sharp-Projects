using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main()
        {
            // string concatenation
            string str1 = "This is the first part, ";
            string str2 = "this is the second part, ";
            string str3 = "and this is the third part of this sentence.";
            string concatenated = str1 + str2 + str3;
            Console.WriteLine(concatenated);

            string lower = "uppercase";
            string upper = lower.ToUpper();
            // ToUpper() does not change the original string.
            Console.WriteLine(lower);
            Console.WriteLine(upper);

            StringBuilder paragraph = new StringBuilder("This is the second sentence of the paragraph. ");
            // Insert takes two arguments, the index to insert at, and the string to insert
            paragraph.Insert(0, "This is the first sentence of the paragraph. ");
            // Append adds to the end of the string
            paragraph.Append("This is the third sentence of the paragraph. ");
            paragraph.Append("This is the fourth sentence of the paragraph. ");
            paragraph.Append("This is the fifth sentence of the paragraph. ");
            Console.WriteLine(paragraph);
            Console.Read();
        }
    }
}
