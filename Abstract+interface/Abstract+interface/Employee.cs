using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Abstract_interface
{
      class Employee : person
    {
        protected long salary;

        public Employee(int id, string name, int age ,long salary) : base(id, name, age)
        {
            this.salary = salary;
        }

        public override int Id { get =>id; set => id = value; }
        public override int Age { get => age; set => age = value; }
        public long Salary { get => salary; set => salary = value; }

        public override void printInfo()
        {
            Console.WriteLine("Id: " + Id + "\n" +
                "Name: " +Name+"\n" +
                "Age: " + Age+"\n"+
                "Salary: "+Salary);
        }
    }
}
