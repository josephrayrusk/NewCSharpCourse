using System;

namespace pg59exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 34;
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
