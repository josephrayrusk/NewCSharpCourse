using System;

namespace pg44exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.ReadLine();
        }
    }
}
