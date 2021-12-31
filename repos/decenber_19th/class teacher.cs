using System;
namespace december_19th
{
    public class person
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

    public class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
           Console.WriteLine("Explanation begins");
        }
    }
    public class student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is:{0} years old", age);
        }
    }
}

