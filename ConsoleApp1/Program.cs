using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number two: ");
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo) 
            {
                Console.WriteLine("The highest value is: " + numberOne + " The lowest value is: " + numberTwo);

            }

            else 

            {
                Console.WriteLine("The highest value is: " + numberTwo + " The lowest value is: " + numberOne);
            }


            Console.ReadKey();


        }
    }
}
