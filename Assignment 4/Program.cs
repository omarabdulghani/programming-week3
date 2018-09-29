using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
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

            double sum = numberOne + numberTwo + numberThree;
            double average = (numberOne + numberTwo + numberThree) / 3.00;
            double product = numberOne * numberTwo * numberThree;


             //..Number one is the highest and number three is the lowest 

              if (numberOne > numberTwo & numberOne > numberThree & numberTwo > numberThree)
            {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberOne);
                Console.WriteLine("Lowest = " + numberThree);
            }
              //..Number one is the highest and number two is the lowest
 
              else if (numberOne > numberTwo & numberOne > numberThree & numberThree > numberTwo)
            {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberOne);
                Console.WriteLine("Lowest = " + numberTwo);
            }
               //..Number two is the highest and number one is the lowest 

               else if (numberTwo > numberOne & numberTwo > numberThree & numberThree > numberOne)
            {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberTwo);
                Console.WriteLine("Lowest = " + numberOne);
            }
               //..Number two is the highest and number three is the lowest

               else if (numberTwo > numberOne  & numberTwo > numberThree & numberOne > numberThree)
                {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberTwo);
                Console.WriteLine("Lowest = " + numberThree);
            }
             
               //..Number three is the highest and number one is the lowest

               else if (numberThree > numberTwo & numberThree > numberOne & numberTwo > numberOne)
            {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberThree);
                Console.WriteLine("Lowest = " + numberOne);
            }
               //..Number three is the highest and number two is the lowest
  
               else if (numberThree > numberTwo & numberThree > numberOne & numberOne > numberTwo)
            {
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Average = {0:0.00}", average);
                Console.WriteLine("Product = " + product);
                Console.WriteLine("Highest = " + numberThree);
                Console.WriteLine("Lowest = " + numberTwo);
            }
                





            Console.ReadKey();
        }
    }
}
