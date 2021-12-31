using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace array_project
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filestreamobj = new FileStream("C:\\vinay\\bobby.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamobj);
            Console.Write("Enter the number of  records");
            int n;
            
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("id\t\t source\t\t      destination\t\t     date\t\t status\t\tnetwork\t\t");
            int[] id = new int[n];
            string[] source = new string[n];
            string[] destination = new string[n];
            string[] date = new string[n];
            string[] status = new string[n];
            string[] network = new string[n];
         while (sr.Peek() >0)
          {
                string Line = sr.ReadLine();
                string[] values = Line.Split(':');
                if (Line != "")
                {
                    if (values.Length >1)
                    {
                        if(Line.StartsWith ("date"))
                        {
                            string Date   = values[1].Split(' ')[0];

                        }
                        Console.Write(values[1] + "\t\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
            sr.Close();
            Console.WriteLine();
            Console.ReadLine();
            Console.ReadKey();
            

            
        }
    }
}
