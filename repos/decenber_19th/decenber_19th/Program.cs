﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace December_19th
{
    class studentandTeacherTest
    { 
        static void Main()
        {
            bool debug = false;

            //create a Person and make it say hello
            Person myPerson=new Person();
            myPerson.Greet();

            /*create a student, set his age to 21,
            * tell him to Greet and display his age*/
            Student myStudent=new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            /*create a teacher,30 years old,
            **ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
            if (debug)
                Console.ReadLine();
        }
    }
}
            


     