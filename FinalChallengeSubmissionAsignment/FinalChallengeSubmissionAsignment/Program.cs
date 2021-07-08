using System;
using System.Data.Entity;

namespace FinalChallengeSubmissionAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student()
                {
                    FirstName = "Steve",
                    LastName = "Fralix",
                    EmailAddress = "stevenf21codes@outlook.com",
                    CurrentCourse = "C# and .NET"
                };
                db.SaveChanges();

            }
        }
    }




}
