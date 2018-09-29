using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne > numberThree && numberTwo > numberThree)
            {
                Console.Write("Number Three is the lowest of the three");
            }

            

            else 

           {

                Console.Write("The third number is not the lowest of the three");

           }






            Console.ReadKey();



        }
    }
}