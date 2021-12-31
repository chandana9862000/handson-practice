using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int empid, salary;
            string Ename, address, job;
            Console.WriteLine("enter the employee details:");
            Console.WriteLine("Enter the empid:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Salary:");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Ename:");
             Ename = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter the job:");
            job = Console.ReadLine();

            
            Console.WriteLine("\n\n The Employee Details are given below:");
            Console.WriteLine("the empid is:" + empid);
            Console.WriteLine("the salary is:" + salary);
            Console.WriteLine("the ename is:" + Ename);
            Console.WriteLine("the adddress is:" + address);
            Console.WriteLine("the job is:" + job);
            Console.ReadKey();






        }
    }
}
