using System;
namespace pg40exercise
{
    public class Math
    {
       
        public void Method(int firstInput, int secondInput)
        {
            int multnum = secondInput;
            int firstanswer = firstInput * multnum;
            Console.WriteLine(firstInput + " multiplied by " + multnum + " is " + firstanswer + ".");
            Console.WriteLine("firstInput= " + firstInput + "\nsecondInput= " + secondInput);
            return;
        }
    }
}
