using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trash_flow_chart
{
    class Program
    {
        static bool GetChoice()
        {
            string answer = Console.ReadLine();
            while (!(answer.ToLower() == "yes" || answer.ToLower() == "no"))
            {
                Console.WriteLine("Please type yes or no");
                answer = Console.ReadLine();
            }

            if (answer.ToLower() == "no")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lets see if you should take the trash out");
            Console.WriteLine("Is the trash full?");

            if (GetChoice())
            { 
                Console.WriteLine("Did you take it out last time?");
                if (GetChoice())
                {
                    Console.WriteLine("Your are awesome. Everyone loves you!");
                }
                else
                {
                    Console.WriteLine("Would't it be nice if you took it out this time?");
                    if (GetChoice())
                    {
                        Console.WriteLine("Thanks!!. We'll get it next time.");
                    }
                    else
                    {
                        Console.WriteLine("You're wrong.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Carry on and have a good day :)");
            }
            Console.ReadKey();
        }
    }
}
