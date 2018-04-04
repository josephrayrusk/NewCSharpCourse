using System;

namespace pg57exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string today = Console.ReadLine();
            try
            {
                if (Enum.IsDefined(typeof(DaysOfTheWeek), today))
                {
                    Console.WriteLine("Yay");

                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a actual day of the week.");
            }
           
        }
        public enum DaysOfTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
