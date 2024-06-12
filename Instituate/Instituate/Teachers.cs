using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituate
{
    internal class Teachers
    {
        public Teachers(int id, string firstName, string lastName, int age, long number, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.Number = number;
            Salary = salary;
        }
        public Teachers()
        {
           
        }

        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int Age { get; set; }

        private long Number { get; set; }

        private double Salary { get; set; }


        public void TeacherInfo()
        {
            Console.WriteLine("Id: " + Id + "\n" +
                "FirstName: " + FirstName + "\n" +
                "LastName: " + LastName + "\n" +
                "Age: " + Age + "\n" +
                "Number: " + Number+"\n"+
                "Salary: "+Salary);
        }

    }
}
