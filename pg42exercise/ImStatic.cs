using System;
namespace pg42exercise
{
    public static class ImStatic
    {
        public static void Static(int i)
        {
            int staticNumber = 2;
            Console.WriteLine("This is the result of using a static class: " + staticNumber + i);
            return;
        }
    }
}
