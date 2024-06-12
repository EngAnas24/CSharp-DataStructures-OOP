using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface
{
    class teacher : Employee
    {
        public teacher(int id, string name, int age, long salary) : base(id, name, age, salary)
        {

        }

       

        public override void printInfo()
        {
            base.printInfo();
        }
    }
}
