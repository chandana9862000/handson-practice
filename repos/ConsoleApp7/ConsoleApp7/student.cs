﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class student
    {
        public int rollno;
        public string name;
        public string course;
        public double feepaid;
        public  static double Servicetask = 0.123;

        public student(int rollno, string name, string course, int feepaid)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            this.feepaid = feepaid;

        }
        public   void Payment( double amount)
        {
            amount = feepaid +Dueamount;
        }
        public void print()
        {
            Console.WriteLine("rollno:" , rollno);
            Console.WriteLine("name:" ,name);
            Console.WriteLine("course:" , course);
            Console.WriteLine("feepaid:" , feepaid);
            Console.WriteLine("Dueamount:", Dueamount);
        }
        public double Dueamount
        {
            get
            {
                return totalfee - feepaid;

            }
        }
        public double totalfee
        {
            get
            {
                if (course.ToLower() == "c#")
                 return 2000 +(2000*servicetask);
                else if(course.ToLower() == "asp.net")
                 return 3000 +(3000*servicetask);
               return 0;
            }
        }
        public  static double servicetask
        {
            get
            {
                 return servicetask;
            }
            set
            {
                servicetask = value;
            }
            
            
             
                
            
        }
        
    }
}
