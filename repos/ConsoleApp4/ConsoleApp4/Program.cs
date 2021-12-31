using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bike bikeobj = new bike();
            bikeobj.getcolor();
            Console.WriteLine("colour:"+ bikeobj.getcolor());
            Console.ReadKey();
        }
    }
}
