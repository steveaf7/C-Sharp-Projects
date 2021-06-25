using System;


namespace MethodsAndObjectsSubAssignment
{
    // create a class called person and give it two properties, each of data type string.
    // one called FirstName, the other LastName.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // give this class a void method called SayName() that takes no parameters, and writes the persons name
        // like this "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
