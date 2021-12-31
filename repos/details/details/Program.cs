using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace details
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter student rollnumber");
            string rollnumber = Console.ReadLine();
            Console.WriteLine("enter student course");
            string course = Console.ReadLine();
            Console.WriteLine("enter paid amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            student studentobj = new student(name, rollnumber, course);
            studentobj.payment(amount);
            studentobj.print();
            Console.WriteLine(studentobj.dueamountproperty);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
        
