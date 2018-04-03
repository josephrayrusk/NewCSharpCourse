using System;
namespace pg48exercise
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ".");
        }
    }
}
