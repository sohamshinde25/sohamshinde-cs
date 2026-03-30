using System;
namespace CS
{
    class Temp
    {
        public static void Run()
        {
            Console.WriteLine("What is the temperature outside?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if ( temp > 20 && temp < 30)
            {
                Console.WriteLine("The weather is nice outside");
            }

            else if ( temp > 30)
            {
                Console.WriteLine("It's hot weather");
            }

            else
            {
                Console.WriteLine("It's cold weather");
            }

        }
    }
}