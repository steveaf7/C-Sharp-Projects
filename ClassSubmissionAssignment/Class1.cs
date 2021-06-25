

namespace ClassSubmissionAssignment
{
    // Create a class. 
    public class Class1
    {
        // constructor for Class1
        public Class1()
        {
            Answer = 0;
        }
        public int Answer { get; set; }

        //create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void Divide(int number)
        {
            Answer = number / 2;
            return;
        }

        // create a method with output parameters. 
        public void MultiplyBy3and4(out int times3, out int times4, int number)
        {
            times3 = number * 3;
            times4 = number * 4;
            return;
        }

        //overload a method
        public void Divide(int number, int divisor)
        {
            Answer = number / divisor;
            return;
        }
    }
}
