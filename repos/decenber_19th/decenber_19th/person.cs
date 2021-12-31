using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decenber_19th
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    class teacher : Person
    { 
        private string subject;
        public void Explain()
        {
           Console.WriteLine("Explanation begins");
        }
    }
     class student : Person
     {
        public void ShowAge()
        {
            Console.WriteLine("My age is:{0} years old", age);
        }
    }
}

