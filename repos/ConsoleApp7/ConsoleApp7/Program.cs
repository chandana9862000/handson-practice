using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student(3,"chandana","c#",500);
            student obj1 = new student(4, "charitha", "asp.net", 1000);
            obj.Payment(2000);
            obj1.Payment(3000);
            obj.print();
            obj1.print();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
