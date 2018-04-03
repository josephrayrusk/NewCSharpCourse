using System;

namespace pg50exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Type your first name.");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Type your last name.");
            employee.LastName = Console.ReadLine();

            employee.SayName();
            employee.Quit(employee);

        }
    }
}
