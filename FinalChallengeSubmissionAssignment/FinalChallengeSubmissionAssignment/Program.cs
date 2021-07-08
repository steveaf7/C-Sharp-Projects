using System;

namespace FinalChallengeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentName = "Steven Fralix",
                    EmailAddress = "stevenf21cods@outlook.com"
                };
                db.Students.Add(student);
            }
        }
    }
}
