using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructore
{
    public class Group
    {
        Student stu1;
        Student stu2;

        public Group(Student s1, Student s2)
        {
            stu1 = s1;
            stu2 = s2;
        }
        public Group(Group g)
        {
            stu1 = new Student(g.stu1);

            stu2 = new Student(g.stu2);
           

        }
        

        public void Print()
        {
            string info = "________________\n" +
                "Age : " + stu1.age +"\n"+
                "Grade: " + stu1.grade+ "\n" +
              "______________________________\n" +
                "Age : " + stu2.age + "\n" +
                "Grade: " + stu2.grade + "\n" +
                "______________________________";
            Console.WriteLine(info);
        }
       
    }
}
