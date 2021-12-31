using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Queue_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qobj = new Queue();
            int total = 3;
            for(int i=0;i<total;i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                qobj.Enqueue(new person()
                {
                    Name = name,
                    Age = age
                });
            }
            foreach(person p in qobj)
            {
               
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
