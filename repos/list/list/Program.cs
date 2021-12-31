using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> la = new List<int>();
            la.Add(3);
            la.Add(6);
            la.Add(8);
            la.Add(9);
            foreach (int i in la)
            
                Console.Write(((i*3)+4)+ " ");
            
           
            Console.ReadLine();
        }
    }
}
