using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mamespace_name
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondnumber = 1,nextnumber, numberofelements;
            Console.Write("Enter the number of elements to print : ");
            numberofelements = int.Parse(Console.ReadLine());
            if (numberofelements < 2)
            {
                Console.Write("please enter a number greater than two");
            }
            else
            {
                Console.Write(firstNumber + " " + secondnumber + " ");


                for (int i = 2; i < numberofelements; i++) 
                {
                    nextnumber = firstNumber + secondnumber;
                    Console.Write(nextnumber + " ");
                    firstNumber = secondnumber;
                    secondnumber = nextnumber;


                }
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.ReadKey();


            
        }
        
        
        
    }
}
