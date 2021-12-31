using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_program
{
    class person
    {
            object name1 = "juan";
            object name2 = "sara";
            object name3 = "Carlos";
            object age1 = 26;
            object age2 = 31;
            object age3 = 23;
            public void data()
            { 
        
            Stack personlist = new Stack();
            personlist.Push(name1);
            personlist.Push(name2);
            personlist.Push(name3);
          
            
            Stack personage = new Stack();
            personage.Push(26);
            personage.Push(31);
            personage.Push(23);
            for(int i=0;i<=personlist.Count+1;i++)
            {
                Console.WriteLine(personlist.Pop() + "-" + personage.Pop());
            }
        }
    }
}
