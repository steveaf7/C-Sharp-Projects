

namespace MethodSubmissionAssignment
{
    // create a class
    class Class1
    {
        // create method that takes two integers as parameters, one optional. 
        // have the method do a math operation and return an integer result.
        public int method1(int dividend, int divisor = 5)
        {
            int answer = dividend / divisor;
            return answer;
        }
    }
}
