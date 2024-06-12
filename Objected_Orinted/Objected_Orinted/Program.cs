using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objected_Orinted
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();

          Engineer engineer = new Engineer();
            engineer.name();
            Console.ReadLine();

        }
    }
    public class Person
    {

        public void Display()
        {
            Console.WriteLine("Hi am a person");
        }
    }
    public class Employee:Person
    {
        public virtual void Display()
        {
            Console.WriteLine("Hi am a Employee");
        }
    }

    public class Engineer : Employee
    {

        public override new void Display()
        {
            Console.WriteLine("Hi am a Engineer");
        }

        public void name()
        {
            base.Display();
            Console.WriteLine("This is a test");
        }
    }
}
