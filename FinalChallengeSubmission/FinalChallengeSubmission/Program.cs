using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var db = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentName = "Steve Fralix",
                    EmailAddress = "stevenf21codes@outlook.com"
                };

                db.Students.Add(student);
                db.SaveChanges();

                var query = from 
            }
        }
    }
}
