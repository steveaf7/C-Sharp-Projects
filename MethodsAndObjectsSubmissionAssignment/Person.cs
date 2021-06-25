using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    // create a class called person and give it two properties, each of data type string.
    // One called FirstName, the other LastName.
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // give this class a void method called SayName() that takes no parameters and
        // writes the name in the format "Name:[full name]".
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }



}
