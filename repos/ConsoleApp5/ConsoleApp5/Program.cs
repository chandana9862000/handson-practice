using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public void print()
        {
            Console.WriteLine("my name is chandana");
        }

    }
    class execute : Program
    {
        public void print()
        {
            Console.WriteLine("my name is");
        }
    }
    

        public static void Main()
        {
            execute exe = new execute();
             exe.print();
             Console.ReadLine();
         }
     
}
