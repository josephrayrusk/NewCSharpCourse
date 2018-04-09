using System;
using System.IO;
namespace pg65exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            //using string just for exercise purposes only.
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Joseph\Log\testlog.txt", number);
            string readNumber = File.ReadAllText(@"C:\Users\Joseph\Log\testlog.txt");
            Console.WriteLine(readNumber);
        }
    }
}
