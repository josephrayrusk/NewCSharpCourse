using System;
namespace pg42exercise
{
    public class Math
    {

        public int UserInt { get; set; }
        public int Answer { get; set; }

        public int DivTwo()
        {
            return Answer = UserInt / 2;
        }

        public void Overload(int x)
        {
            Console.WriteLine("The number " + x + " was used so 'Overload 1' was used ");
        }

        public void Overload(double x)
        {
            Console.WriteLine("The number " + x + " was used so 'Overload 2' was used ");
        }
    }
}
