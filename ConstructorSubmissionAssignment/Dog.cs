using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Dog
    {
        //chain two constructors together
        //this constructor is for creating a dog before you know anything about the dog. 
        // it will create properties and assign values that we can change later. 
        public Dog() : this(null, 0, null)
        {
        }
        // this is for creating a dog where you know some info about the dog. 
        public Dog(string breed, int age, string color)
        {
            Breed = breed;
            Age = age;
            Color = color;
        }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }
}
