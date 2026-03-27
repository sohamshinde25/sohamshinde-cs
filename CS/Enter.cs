using System;
namespace CS
{
    class Enter
    {
        public static void Run()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You didn't enter your name.");

            }
            else
            {
                Console.WriteLine("Hii," + name);
            }
        }
    }
}