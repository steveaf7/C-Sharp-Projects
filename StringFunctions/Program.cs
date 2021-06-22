using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Steve";
            //string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n \tHello on a tab;";
            //string fileName = "C:\\Users\\Steve";
            //// instead of double slashes, you can also use the @ which tells the compiler to ignore the excape sequences. 
            //string fileName1 = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //Console.WriteLine(trueOrFalse);
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //string nameUpper = name.ToUpper();
            //string nameLower = name.ToLower();


            //Console.WriteLine(length);
            //Console.WriteLine(name);
            //Console.WriteLine(nameUpper);
            //Console.WriteLine(nameLower);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
