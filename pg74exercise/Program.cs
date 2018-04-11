using System;
using System.Collections.Generic;

namespace pg74exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0 ){
                    throw new ArgumentOutOfRangeException();

                }
                Console.WriteLine("Have you celebrated your birthday this year? (Type yes or no)");
                string birthday = Console.ReadLine();
                int thisyear = 1;
                if (birthday == "yes")
                {
                    thisyear = 0;
                }
       
                if (birthday == "no")
                {
                    thisyear = 1;
                }

                else if (birthday != "no" || birthday != "yes"){
                    throw new FormatException();
                }

                String bornIn = Convert.ToString(DateTime.Now.AddYears(-(age + thisyear)));
                String yearborn = Convert.ToString(DateTime.Parse(bornIn).Year);
                Console.WriteLine("You were born in " + yearborn);
                Console.Read();




            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a number greater than 0");
            }
            catch (FormatException){
                Console.WriteLine("You must enter yes or no");
                
            }

        }
    }
}
