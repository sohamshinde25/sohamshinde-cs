using System;
namespace CS
{
    class Condition
    {
        public static void Run()
        {
            Console.WriteLine("Enter your age:");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }


                        
        }
    }
}