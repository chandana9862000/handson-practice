using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_project
{
    class hospital
    {
        public void doctor()
        {
            FileStream filestreamobj = new FileStream("c:\\Test\\myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("Welcome to my hospital");
            Console.WriteLine("Enter doctor name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter doctor id:");
            string id = Console.ReadLine();
            Console.WriteLine("hospital name:");
            string hospitalname = Console.ReadLine();
            Console.WriteLine("designation:");
            string designation = Console.ReadLine();
            sw.WriteLine(name);
            sw.WriteLine(id);
            sw.WriteLine(hospitalname);
            sw.WriteLine(designation);
            sw.Close();
            filestreamobj.Close();
            Console.WriteLine("hospital details saved successfully");

        }
    }
}





