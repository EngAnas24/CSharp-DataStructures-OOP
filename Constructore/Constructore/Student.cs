using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructore
{
    public class Student
    {
       public int age;
        public double grade;

        public Student(int age, double grade)
        {
            this.age = age;
            this.grade = grade;
        }
        public Student(Student s)
        {
            this.age = s.age;
            this.grade = s.grade;
        }
       /* public Student(Student s)
        {
            s = new Student(s);
        }*/

        public void Print()
        {
            Console.WriteLine("Student's Age: "+age+" \n Student's Grade: "+grade);
        }
    }
}
