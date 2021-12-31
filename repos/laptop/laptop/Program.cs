using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string price = Console.ReadLine();
            string processor = Console.ReadLine();
            string ram = Console.ReadLine();
            string Hardware = Console.ReadLine();
            subdiv subdivobj = new subdiv();
            subdivobj.lapdet();

            subdivobj.laptopdetails(name, price, processor, ram, Hardware);
            Console.WriteLine('\n');
            Console.ReadKey();
           
        }
    }
}
