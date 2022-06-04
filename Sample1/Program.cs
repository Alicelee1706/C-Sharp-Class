using System;

namespace Sample1
{
    internal class Program
    {
        static void Main(string[] ii)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +name+ "!!");
            Console.WriteLine("What year did you born?");
            string yob = Console.ReadLine();
            int age = 2022 - Convert.ToInt32(yob);
            Console.WriteLine("So you are {0} years old!", age);
            Console.Write("Input a: ");
            string a1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            Console.Write("Input b: ");
            string b1 = Console.ReadLine();
            int b = Convert.ToInt32(b1);
            int min = (a > b) ? 1 : 2;
            Console.WriteLine(min);
        }
    }
}