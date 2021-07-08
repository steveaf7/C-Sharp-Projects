using System;
using System.Collections.Generic;
using System.Text;

namespace FinalChallengeSubmissionAsignment
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string CurrentCourse { get; set; }

        public Grade Grade { get; set; }
    }

}
