using System;

namespace pg40exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter your first integer");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer.");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            math.Method(firstInput, secondInput);

        }
    }
}
