using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _c_to__F
{
    public class Utility

    {
        public void FtoC()
        {
            Console.WriteLine("The temperature is");
            string Ftemp = Console.ReadLine();
            double ftemp = Convert.ToDouble(Ftemp);
            double C = (ftemp - 32) * 5 / 9;
            Console.WriteLine($"The temperature is {C}°C");
            
        }

        public void CtoF()
        {
            Console.WriteLine("The temperature is");
            string Ctemp=Console.ReadLine();
            double ctemp = Convert.ToDouble(Ctemp);
            double F = (ctemp + 32) * 9/ 5;
            Console.WriteLine($"The temperature is {F}°F");
        }

        public void Bmilb()
        {
            Console.WriteLine($"Enter your weight in lb:");
            
            string weightlb = Console.ReadLine();
            double weight = Convert.ToDouble(weightlb);

            Console.WriteLine("Enter your height in inches:");
            string heightlb = Console.ReadLine();
            double height = Convert.ToDouble(heightlb);

            double bmi = (703*weight) /( height * height);
            Console.WriteLine($"Your BMI is {bmi}");
        }

        public static void Bmikg()
        {
            Console.WriteLine("Enter your weight in kg:");
            string weightkg = Console.ReadLine();
            double weight = Convert.ToDouble(weightkg);

            Console.WriteLine("Enter your height in centimeter:");
            string heightkg = Console.ReadLine();
            double height = Convert.ToDouble(heightkg);

            double bmi = weight / (height * height) ;
            Console.WriteLine($"Your BMI is {bmi}");
            
        }

    }
}
