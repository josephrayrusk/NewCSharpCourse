using System;
namespace pg50exercise
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ".");
        }

        public void Quit (Person person)
        {
            Console.WriteLine("To quit type 'q'.");
            string quit = Console.ReadLine();
            if (quit == "q")
            {
                Console.WriteLine(person.FirstName + " decided to quit");
                Console.Read();
                Environment.Exit(0);
            }
            else Console.WriteLine("Ok then... Quit manually...");
        }
    }
}
