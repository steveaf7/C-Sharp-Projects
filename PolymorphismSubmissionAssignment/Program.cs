using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
            IQuittable employee = new Employee();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
