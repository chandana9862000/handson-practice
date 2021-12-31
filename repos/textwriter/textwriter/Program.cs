using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textwriter
{
class Program
{
        static void Main(string[] args)
        { 
            string file = "C:\\milky\\bubbly.txt";
            TextWriter textwriterobj = File.CreateText(file);
            textwriterobj.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Successfully Added current date and time");
            textwriterobj.Close();
            //reading file
            TextReader textreaderobj = File.OpenText(file);
            Console.Write("Reading current Time");
            Console.WriteLine(textreaderobj.ReadToEnd());
            textreaderobj.Close();
            Console.ReadKey();

        }
    }
}
