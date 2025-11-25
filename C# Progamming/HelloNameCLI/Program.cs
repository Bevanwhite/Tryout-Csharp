using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadKey();
        }
    }
}
