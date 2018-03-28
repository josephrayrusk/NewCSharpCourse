using System;
namespace pg38exercise
{
    public class Math
    {
        public int UserInput { get; set; }
        public int Answer { get; set; }
        public double DAnswer { get; set; }

        public int ThisThing()
        {           
           return Answer = UserInput + 35;
        }
        public double ThisThing(double times)
        {
            return DAnswer = UserInput * (2 * times);

        }
        public int ThisThing(int div, int mult)
        {
            return Answer = UserInput * (100 / div)* mult;
        }
    }
}
