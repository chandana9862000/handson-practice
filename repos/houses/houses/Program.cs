using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace houses
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\roja\\Murali.txt";
            StreamWriter streamwriterobj = new StreamWriter(file);
            Console.Write("Enter housename");
            string housename = Console.ReadLine();
            streamwriterobj.WriteLine("housename:"+housename);
            Console.Write("enter Street");
            string Street = Console.ReadLine();
            streamwriterobj.WriteLine("street");
            Console.Write("enter houseid");
            string houseid = Console.ReadLine();
            streamwriterobj.WriteLine(houseid);
            streamwriterobj.Close();
            string mean = "housename:chandana street:ramarao colony houseid:34";
            string[] house = mean.Split(':');
            for (int i=0; i < house.Length; i++)
            {
                Console.Write(house[i]);
            }
            Console.ReadLine();

        }

    }
}
