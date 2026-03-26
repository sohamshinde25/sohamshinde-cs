using System;

namespace CS
{
    class RandomDemo
    {
        public static void Run()
        {
            System.Random random = new System.Random();

            int a = random.Next(1, 7);

            Console.WriteLine(a);
        }
    }
}