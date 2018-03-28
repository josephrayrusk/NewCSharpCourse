using System;

namespace pg39exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number.");
            math.UserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number... if you feel like it.");
            try
            {
                math.OptUserInput = Convert.ToInt32(Console.ReadLine());
            }
            catch{
                math.OptUserInput = 0;
            }

            if (math.OptUserInput > 0){
                Console.WriteLine(math.UserInput + " + " + "is equal to: " + math.mathOperation());
            }
            else Console.WriteLine("You typed " + math.UserInput);
        }
    }
}
