using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of working hours: ");

            double numberHrs = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter number of years: ");

            double numberYrs = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of failures: ");

            double numberFlrs = double.Parse(Console.ReadLine());

            
            if ( numberHrs > 10000 & numberYrs > 7 & numberFlrs > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }

            else if (numberHrs > 10000 & numberYrs > 7 & numberFlrs < 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }

            else if (numberHrs > 10000 & numberYrs < 7 & numberFlrs < 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }

            else if (numberHrs < 10000 & numberYrs < 7 & numberFlrs > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }

          else if (numberHrs < 10000 & numberYrs > 7 & numberFlrs < 25)
            {
                Console.WriteLine("Machine needs to be replaced.");

            }

            else if (numberHrs < 10000 & numberYrs < 7 & numberFlrs < 25)

            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            

            Console.ReadKey();



        }
    }
}
