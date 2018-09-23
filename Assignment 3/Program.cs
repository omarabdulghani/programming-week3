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
            Console.WriteLine("Enter the first number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne > numberThree && numberTwo > numberThree)
            {
                Console.WriteLine("Number Three is the lowest of the three");
            }

            

            else 

           {

                Console.WriteLine("The third number is not the lowest of the three");

           }






            Console.ReadKey();



        }
    }
}