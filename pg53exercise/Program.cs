using System;

namespace pg53exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Jill";
          
            person.LastName = "Felise";
           
            person.Id = 100;

            Person person1 = new Person();

            person.FirstName = "Steve";

            person.LastName = "Walker";

            person.Id = 101;


            Console.ReadLine();
        }
    }
}
