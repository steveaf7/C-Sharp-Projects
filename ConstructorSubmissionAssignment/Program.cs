using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            // create a consant variable.
            const string creator = "Steve F";
            Console.WriteLine(creator);
            // create a variable using the keyword "var"
            var dogtionary = new Dictionary<string, int>() { ["Rottie"]= 3, ["Bandit"]= 5};
            Console.WriteLine(dogtionary["Rottie"]);
            Dog dog = new Dog("Bandit", 5, "brown");
            Dog dog1 = new Dog();
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog1.Age);
            Console.ReadLine();
        }
    }
}
