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
            Console.WriteLine("Enter first number: ");
            double firstnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondnumber = double.Parse(Console.ReadLine());

            if (firstnumber > secondnumber && firstnumber % secondnumber == 0)
            {
                Console.WriteLine("Number 1 is a mulitple of number 2");
            }

            else if (secondnumber > firstnumber && secondnumber % firstnumber == 0)
            {

                Console.WriteLine("Number 2 is mulitple of number 1");
            }

            else
            {
                Console.WriteLine("Numbers are no multiples");
            }

            Console.ReadKey();


        }
    }
}
