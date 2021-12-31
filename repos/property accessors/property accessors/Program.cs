using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_accessors
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            double Radius = c.Radiusproperty;       //double radius = c.Radius   getting the old value
            c.Radiusproperty=12.33;                 //c.Radius = 56.88           setting the new value
            Console.WriteLine(c.Radiusproperty);
            Console.ReadKey();
            
            
        }
    }
    //property is a member of class using which is used to set and get the data from a data field of a class.
    public class circle
    {
           double Radius = 12.34;
       
        public double Radiusproperty      //combining two methods together and making into a simple form is called property.
        {
            get { return Radius; }         //represents a value returning method  without parameter
            set //{ Radius = value; }     //represents a non-value returning method with parameter
            {
                if (value > Radius)
                    Radius = value;
            }
        }
    
        
        public double  GetRadius()            //provides only get access to  the value
        {
            return Radius;

        }
         public void SetRadius(double value)    //provides only set access to the value
         {
             Radius = value;
         }
    }
}
