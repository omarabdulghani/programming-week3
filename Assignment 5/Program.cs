using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstnumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondnumber = double.Parse(Console.ReadLine());

            if (firstnumber > secondnumber && firstnumber % secondnumber == 0)
            {
                Console.Write("Number 1 is a mulitple of number 2");
            }

            else if (secondnumber > firstnumber && secondnumber % firstnumber == 0)
            {

                Console.Write("Number 2 is mulitple of number 1");
            }

            else
            {
                Console.Write("Numbers are no multiples");
            }

            Console.ReadKey();


        }
    }
}
