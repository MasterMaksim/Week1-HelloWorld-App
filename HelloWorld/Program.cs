using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string MyName;
            MyName = Console.ReadLine();

            Console.WriteLine("Hello," + MyName);

            Console.Read();
        }
    }
}
