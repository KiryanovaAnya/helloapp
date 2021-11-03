using System;

namespace HelloApp
{
    class Program
    {
        static void GreetBlack()
        {
            Console.WriteLine("Hello black");
        }

        public static void GreetWhite()
        {
            Console.WriteLine("Hello white");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone");
            GreetWhite();
            GreetBlack();
        }
    }
}
