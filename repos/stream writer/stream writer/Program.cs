using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stream_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\chandu\bobby.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(DateTime.Now.ToString());
                Console.WriteLine("Successfully Added Current Date and Time");
            }
            using (StreamReader reader = new StreamReader(file))
            {
                Console.Write("Reading Current Time :");
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();

        }
    }
}
