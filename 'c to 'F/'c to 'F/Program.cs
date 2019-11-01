using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _c_to__F
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool displaymenu = true;
            while (displaymenu)
            {
                displaymenu = Mainmenu();
            }
            
        }
        private static bool Mainmenu()
        {
            
            Console.WriteLine("Chose methods");
            Console.WriteLine("A. BMI kgs ");
            Console.WriteLine("B. BMI lbs ");
            Console.WriteLine("C.°C to °F");
            Console.WriteLine("D.°F to °C");
            Console.WriteLine("E. Exit");
            string result = Console.ReadLine();
            if (result == "A")
            {
                Utility BMIkg = new Utility();
                Utility.Bmikg();
                return true;
            }
            else if (result == "B")
            {
                Utility BMIlb = new Utility();
                BMIlb.Bmilb();
                
                return true;
                
                
            }
            else if (result == "C")
            {
                Utility ctof = new Utility();
                ctof.CtoF();
                return true;
                

            }
            else if (result == "D")
            {
                Utility ftoc = new Utility();
                ftoc.FtoC();
                return true;

                
                
            }
            else
            {
                return false;
            }

        }

        
    }
}
