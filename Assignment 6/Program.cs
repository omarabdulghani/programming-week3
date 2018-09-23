using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            double score = double.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("grade: A");
                Console.WriteLine("course passed");
            }

            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("grade: B");
                Console.WriteLine("course passed");
            }

            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("grade: C");
                Console.WriteLine("course passed");

            }

            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("grade: D");
                Console.WriteLine("course not passed");

            }

            else if (score <= 59)

            {
                Console.WriteLine("grade: F");

                Console.WriteLine("course not passed");

            }

            Console.ReadKey();
        }
    }
}
