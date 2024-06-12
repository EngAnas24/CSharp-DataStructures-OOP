using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface
{
    class Mechanic_Engineer :Employee,Engineer
    {
        public Mechanic_Engineer(int id, string name, int age, long salary) : base(id, name, age, salary)
        {
        }

        public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void printInfo()
        {
            base.printInfo();
        }
    }
}
