using System;

namespace pg42exercise
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number");

            math.UserInt = Convert.ToInt32(Console.ReadLine());
            math.DivTwo();
            Console.WriteLine(math.UserInt + " divided by two is: " + math.Answer + ".");
            math.Overload(2.2);
            math.Overload(1);
            ImStatic.Static(math.UserInt);

        }
    }
}
