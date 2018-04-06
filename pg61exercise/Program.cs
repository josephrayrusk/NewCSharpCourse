using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace pg61exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            employees.Add(new Employees { FirstName = "Joe", LastName = "Smith", Id = 1 });
            employees.Add(new Employees { FirstName = "Steve", LastName = "Smith", Id = 2 });
            employees.Add(new Employees { FirstName = "Frank", LastName = "Smith", Id = 3 });
            employees.Add(new Employees { FirstName = "Philip", LastName = "Smith", Id = 4 });
            employees.Add(new Employees { FirstName = "Joe", LastName = "Daniels", Id = 5 });
            employees.Add(new Employees { FirstName = "Sarah", LastName = "Smith", Id = 6 });
            employees.Add(new Employees { FirstName = "Frankie", LastName = "Smith", Id = 7 });
            employees.Add(new Employees { FirstName = "Jill", LastName = "Smith", Id = 8 });
            employees.Add(new Employees { FirstName = "Christina", LastName = "Smith", Id = 9 });
            employees.Add(new Employees { FirstName = "Mike", LastName = "Smith", Id = 10 });
            employees.Add(new Employees { FirstName = "Laura", LastName = "Smith", Id = 11 });

            Console.WriteLine(employees.Count);

            foreach (Employees employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }

            }
            List<Employees> nameresult  = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employees employee in nameresult)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
          
            List<Employees> idresult = employees.Where(x => x.Id > 5).ToList();
            foreach (Employees employee in idresult)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " id: " + employee.Id);
            }
                                           
            Console.Read();
        }
    }
}