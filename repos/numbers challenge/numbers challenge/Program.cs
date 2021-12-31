using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_challenge
{
    class Program
    {
        public static string CtoF(double celcius)
        {
            double fahrenheit;
            
            if (celcius < -273.15)
            {
                return "Temperature below absolute zero!";
            }
            fahrenheit = celcius * 1.8 + 32;
            return $"T= {fahrenheit}F";
        }
        public static void  Main()
        {
            Console.WriteLine(CtoF(0));
            Console.WriteLine(CtoF(100));
            Console.WriteLine(CtoF(-300));
            Console.ReadLine();
        }
    }
    
}
