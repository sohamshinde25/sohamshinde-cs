using System;
using System.Threading.Tasks.Dataflow;
namespace CS
{
    class Day
    {
        public static void Run()
        {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                Console.WriteLine("It's a weekday.");
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("It's a weekend.");
            }
            else
            {
                Console.WriteLine("Invalid day.");
            }
        }
    }
}