using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_collection
{
    class person
    {
        protected string firstname;
        protected string lastname;
        protected int idNumber;
        public person(string firstname, string lastname, int identification)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.idNumber = identification;

        }
        public void printperson()
        {
            Console.WriteLine("Name:" + lastname + "," + firstname + "\nID:" + idNumber);
        }
    }
        class Student : person
        {
            private int[] testscores;
            public Student(string firstname, string lastname, int id, int[] testscores) :base(firstname,lastname,id)
            {
                this.testscores = testscores;
                this.firstname = firstname;
                this.lastname = lastname;
                this.idNumber = id;
            }
            public char calculate()
            {
                float average = 0;
                float sum = 0;
                char grade = ' ';
                for (int i=0,length = this.testscores.Length; i < length;i++)
                {
                    sum += this.testscores[i];
                }
                average = sum / (float)this.testscores.Length;
                if(90 <= average && average <= 100)
                {
                    grade = 'O';
                }
                else if(80 <= average && average < 90)
                {
                    grade = 'E';

                }
                else if(70 <= average && average <80)
                {
                    grade = 'A';
                }
                else if(55 <= average && average < 70)
                {
                    grade = 'p';

                }
                else if (40 <= average && average <55)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'T';
                }
                return grade;
            }
        }
    

}
