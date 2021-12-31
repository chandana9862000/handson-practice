using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_creation
{
    class Program
    {
        static void Main()
        {
            hospital hospitalobj = new hospital();
            hospitalobj.createhospital();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
