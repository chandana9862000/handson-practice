﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_project
{
    class Program
    {
        static void Main()
        {
            hospital hospitalobj = new hospital();
            hospitalobj.doctor();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
