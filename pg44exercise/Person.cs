using System;
namespace pg44exercise
{
    public class Person
    {
        public string FirstName { get;set;  }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName +".");
        }
    }
}
