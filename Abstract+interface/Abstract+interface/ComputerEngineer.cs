using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface
{
    class ComputerEngineer :Employee,Engineer
    {
        private string companyname;
        public ComputerEngineer(int id, string name, int age, long salary,string CmpnyName) : base(id, name, age, salary)
        {
            this.companyname = CmpnyName;
        }

        public string CompanyName { get => companyname; set => companyname = value; }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Company Name: " + CompanyName);
        }
    }
}
