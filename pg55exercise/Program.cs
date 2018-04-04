using System;

namespace pg55exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>();
            things.Things.Add("Hello,");
            things.Things.Add("it's me.");
            things.Things.Add("I was wondering if...");
            things.Things.Add("Nevermind");

            Employee<int> otherthings = new Employee<int>();
            otherthings.Things.Add(3);
            otherthings.Things.Add(2);
            otherthings.Things.Add(1);
        }
    }
}
