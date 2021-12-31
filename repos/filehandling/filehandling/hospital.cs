using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class hospital
    {
        public void doctor()
        {
            FileStream filestreamobj = new FileStream("C:\\test\\myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("Welcome to my hospital");
            Console.WriteLine("Enter doctor name:");
            string doctorname = Console.ReadLine();
            Console.WriteLine("Enter doctor id:");
            string doctorid = Console.ReadLine();
            Console.WriteLine("hospital name:");
            string hospitalname = Console.ReadLine();
            Console.WriteLine("designation:");
            string designation = Console.ReadLine();
            sw.WriteLine("doctorname:"+doctorname);
            sw.WriteLine("doctorid:"+doctorid);
            sw.WriteLine("hospitalname:"+hospitalname);
            sw.WriteLine("designation:"+designation);
            sw.Close();
            filestreamobj.Close();
            Console.WriteLine("hospital details saved successfully");

         }
    }
} 
