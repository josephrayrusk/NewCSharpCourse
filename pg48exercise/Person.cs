using System;
namespace pg48exercise
{
    public abstract class Person
    {
        public string FirstName { get;set;  }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ".");
        }
    }
}
