using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (i.e 1 to 4): ");
            double enteredNumber = double.Parse(Console.ReadLine());

            switch (enteredNumber)
            {
                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine("Diamonds");
                    break;
                case 3:
                    Console.WriteLine("Hearts");
                    break;
                case 4:
                    Console.WriteLine("Spades");
                    break;

                default:
                    Console.WriteLine("Incorrect Input!");
                    break;
            }









                Console.ReadKey();
            }
    }
}
