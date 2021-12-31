using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queue_program
{
    class person
    {
        string Name { get; set; }
        int Age { get; set; }
        public override string ToString()
        {
            return Name +"-"+ Age;
        }
    }
}
