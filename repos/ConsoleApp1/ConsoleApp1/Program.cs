using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filestreamobj = new FileStream("C:\\new\\myfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamobj);
            Console.WriteLine("id \t\tsource\t\t       destination\t\t     date\t\t status\t\tNetwork\t\t");
            while (sr.Peek() > 0)
            {
                string Line = sr.ReadLine();
                string[] values = Line.Split(':');
                if (Line !="")
                {
                    if (values.Length > 1)
                    {
                        if(Line.StartsWith("Date"))
                        {
                            string date = values[1].Split(' ')[0];
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
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
