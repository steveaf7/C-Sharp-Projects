using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of 10 employees, each with a firstName, lastName and Id. 
            // at least two employees should be named "Joe."
            Employee emp0 = new Employee() { firstName = "Joe", lastName = "Tech", Id = 0 };
            Employee emp1 = new Employee() { firstName = "Mike", lastName = "Johnson", Id = 1 };
            Employee emp2 = new Employee() { firstName = "Joe", lastName = "Smith", Id = 2 };
            Employee emp3 = new Employee() { firstName = "Rick", lastName = "Wilson", Id = 3 };
            Employee emp4 = new Employee() { firstName = "Jamie", lastName = "Williams", Id = 4 };
            Employee emp5 = new Employee() { firstName = "Beth", lastName = "Sorenson", Id = 5 };
            Employee emp6 = new Employee() { firstName = "Janet", lastName = "Samsung", Id = 6 };
            Employee emp7 = new Employee() { firstName = "Timothy", lastName = "Daily", Id = 7 };
            Employee emp8 = new Employee() { firstName = "Joe", lastName = "Fralix", Id = 8 };
            Employee emp9 = new Employee() { firstName = "Joe", lastName = "Hill", Id = 9 };

            List<Employee> employees = new List<Employee>()
            {
                emp0, emp1,emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9,
            };

            // using a foreach loop, create a newList of all employees with the firstName "Joe"
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    newList.Add(employee);
                }
            }
            // using a lambda expression, create a new list of all employees with the first name "Joe".
            List<Employee> firstNameJoe = employees.Where(x => x.firstName == "Joe").ToList();

            // using a lambda expression, create a new list of all employees with an Id greater than 5. 
            List<Employee> idGreaterThan5 = employees.Where(x => x.Id > 5).ToList();

            // should print '4' three times, there are four employees with firstName of "Joe"  
            // and four with an Id > 5.
            Console.WriteLine(newList.Count());
            Console.WriteLine(firstNameJoe.Count());
            Console.WriteLine(idGreaterThan5.Count());
            Console.ReadLine();
        }
    }
}
