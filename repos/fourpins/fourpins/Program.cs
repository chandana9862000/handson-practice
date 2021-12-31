using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace fourpins
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "1","2","3","4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
                Console.ReadLine();
            }
        }
        public static List<string>test(List<string>nums)
        {
            IEnumerable<string> e = nums.Select(x => x=x+x+x+x);
            return e.ToList();
        }
    } 
}
