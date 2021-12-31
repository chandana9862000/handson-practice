using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name:");
            string firstname = Console.ReadLine();
            Console.Write("Enter the last name:");
            string lastname = Console.ReadLine();
            Console.Write("enter id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of sub:");
            int numscores = int.Parse(Console.ReadLine());
            int[] testscores = new int[numscores];
            for (int i = 0; i < numscores; i++)
            {
                Console.Write("Enter test score {0}:", (i + 1));
                testscores[i] = int.Parse(Console.ReadLine());
            }
            Student studentobj = new Student(firstname, lastname, id, testscores);
            studentobj.printperson();
            Console.WriteLine("Grade:" + studentobj.calculate());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
