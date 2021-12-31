using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice
{
    public class bike
    {
        public string bikedetails(string color, string engine, string name)
        {
            Console.WriteLine("colour:" + color);
            Console.WriteLine("engine:" + engine);
            Console.WriteLine("name:" + name);
            return "bikedetails saved successfully";
        }
        public int bikemile(int mileage)
        {
            Console.WriteLine("mileage:" + mileage);
            return mileage;
        }




    }
}
