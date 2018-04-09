using System;

namespace pg67exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please type a number.");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(DateTime.Now.AddHours(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
