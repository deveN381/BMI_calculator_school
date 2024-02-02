using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_calc
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your height.");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight.");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / ((height / 100) * (height / 100));
            double bmiprint = Math.Round(bmi, 0);
            Console.WriteLine(bmiprint);
            if (bmiprint < 20)
            {
                Console.WriteLine("You are underweight.");
            }
            if (bmiprint >= 20 && bmiprint <= 25)
            {
                Console.WriteLine("Your weight is normal.");
            }
            else if (bmiprint > 25)
            {
                Console.WriteLine("You are overweight :(");
            }

        }
    }
}
