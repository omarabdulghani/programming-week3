using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());


            Console.Write("Enter height (cm): ");
            double height = double.Parse(Console.ReadLine());



            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();


            double BMI = weight / ( (height / 100.0) * (height / 100.0) );
            double healthymalerangeone = 20 * (height / 100.0) * (height / 100.0);
            double healthymalerangetwo = 25 * (height / 100.0) * (height / 100.0);

            double healthyfemalerangeone = 19 * (height / 100.0) * (height / 100.0);
            double healthyfemalerangetwo = 24 * (height / 100.0) * (height / 100.0);



            if ( gender == "male")
            {
                Console.WriteLine("bmi-value: {0:0.0}", BMI);
                Console.WriteLine("normal bmi-values (min .. max): 20..25 ");
                Console.WriteLine("healthy weight range: {0:0.0} .. {1:0.0}", healthymalerangeone, healthymalerangetwo);


            }
            
            else if (gender == "female")

            {
                Console.WriteLine("bmi-value: {0:0.0}", BMI);
                Console.WriteLine("normal bmi-values (min .. max): 19..24 ");
                Console.WriteLine("healthy weight range: {0:0.0} .. {1:0.0}", healthyfemalerangeone, healthyfemalerangetwo);
            }

            Console.ReadKey();

            

        }
    }
}
