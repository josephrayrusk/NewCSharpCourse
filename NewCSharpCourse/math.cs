using System;
namespace NewCSharpCourse
{
    public class Math
    {
        public void Addition()
        {
            Console.WriteLine("Type a number too add to 10");
            int add = Convert.ToInt32(Console.ReadLine());
            int total = add + 10;
            Console.WriteLine(total);
        }
        public void Multiplication()
        {
            Console.WriteLine("Type a number to multiply 30 by.");
            int mult = Convert.ToInt32(Console.ReadLine());
            double total = mult * 30;
            Console.WriteLine(total);
        }
        public void Division()
        {
            Console.WriteLine("Type a number to divide 304309 by.");
            int div = Convert.ToInt32(Console.ReadLine());
            int total = 304309/div;
            Console.WriteLine(total);
        }



    }
}

