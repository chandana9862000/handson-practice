using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_creation
{
    class hospital
    {
        public void createhospital()
        {
            
            FileStream filestreamobj = new FileStream("C:\\chandana\\charitha.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("Welcome to my hospital");
            Console.WriteLine("Enter hospitalname");
            string hospitalname = Console.ReadLine();
            sw.WriteLine("hospitalname:" + hospitalname);
            sw.Close();
            filestreamobj.Close();
        }
    }
}
