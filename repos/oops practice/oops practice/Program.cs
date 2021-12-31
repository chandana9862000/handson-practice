using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice
{
    class program
    {
         static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string engine = Console.ReadLine();
            string name = Console.ReadLine();
            int mileage = int.Parse(Console.ReadLine());
            bike bikeobj = new bike();
            bikeobj.bikedetails(color, engine, name);
            bikeobj.bikemile(mileage);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
