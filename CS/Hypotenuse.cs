using System;
namespace CS
{
    class Hypotenuse
    {
        public static void Run()
        {
            Console.WriteLine("Enter side A: ");
        
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");

            double b = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter Side C: ");

            double c = System.Math.Sqrt((a*a) + (b*b));

            Console.WriteLine("The hypotenuse is: " + c);




        }
    }
}