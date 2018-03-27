using System;

namespace NewCSharpCourse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Math math = new Math();
                math.Addition();
                math.Division();
                math.Multiplication();
                Console.Read();

            }
            catch{
                Console.WriteLine("Please enter a vaid number.");

            }
        }
    }
}
