using System;

namespace pg38exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number.");
            math.UserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. 3. Display the result to the screen.");
            Console.WriteLine(math.ThisThing());
            Console.WriteLine("Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer./nIn the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen");
            Console.WriteLine(math.ThisThing(3.2));
            Console.WriteLine("Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.");
            Console.WriteLine(math.ThisThing(math.UserInput,5));
        }
    }
}
