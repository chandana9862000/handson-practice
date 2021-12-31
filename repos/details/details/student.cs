using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace details
{
    class student
    {
        public string name;
        public string rollnumber;
        public string course;
        public int feepaid;
        public int totalfee;
        public student (string name,string rollnumber,string course)
        {
            Console.WriteLine("Student name:" + name);
            Console.WriteLine(" student rollnumber:" + rollnumber);
            Console.WriteLine("student course:" + course);
        }
        public void payment(int amount)
        {
            feepaid = feepaid + amount;
        }
        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(rollnumber);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }
        public int dueamountproperty
        {
            get
            {
                return totalfee - feepaid;
            }

        }
        public int Totalfee
        {
            get
            {
                return course == "c#" ? 2000 : 3000;
            }
           
        }
    }
}
