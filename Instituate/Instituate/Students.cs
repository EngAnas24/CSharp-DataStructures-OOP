using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituate
{
    internal class Students
    {
        public Students(int id, string firstName, string lastName, int age, long number)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.Number = number;
        }
        public Students()
        {
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public long Number { get; set;}

        public void StudentInfo()
        {
            Console.WriteLine("--------------------------------\n" +
                "Id: " + Id + "\n" +
                "FirstName: " + FirstName + "\n" +
                "LastName: " + LastName + "\n" +
                "Age: " + Age + "\n" +
                "Number: " + Number+"\n"+
                "-------------------------------" );
        }

    }
}
