using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    // have your employee class from the previous drill inherit that interface and implement the Quit() method. 
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("This is the quit method. ");
        }
    }
}
