﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December_19th
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;
            //Create a Person and make is say hello
            Person myPerson = new Person();
            myPerson.Greet();
            
            /*Create a student,set his age to 21,
              tell him to greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            /*Create a teacher,30 years old,
             * ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();
        }
    }
}
