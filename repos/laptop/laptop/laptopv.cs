using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    class laptopv
    {
        public string laptopdetails(string name, string price, string processor, string ram, string hardware)
        {
            Console.WriteLine("Name of my device:"+name);
            Console.WriteLine("Price="+price);
            Console.WriteLine("processor="+processor);
            Console.WriteLine("ram="+ram);
            Console.WriteLine("hardware="+hardware);
            return "lapdetails are";
        }
    }
     class subdiv : laptopv
     {
        public void lapdet  ()
        {
           Console.WriteLine();
        }
     }
}






