using Institute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Management m = new Management();
            Courses course1 = new Courses("English",3500);
            Teachers teacher1 = new Teachers(1, "Ahmed", "Ali", 24, 05433055030, 545456.456);
            Students student1 = new Students(1, "Mohammed", "Ali", 24, 05433055030);

            Courses course2 = new Courses("ARABIC", 3500);
            Teachers teacher2 = new Teachers(1, "ALi", "Ali", 24, 05433055030, 545456.456);
            Students student2 = new Students(1, "ANAS", "Ali", 24, 05433055030);
            Students student3 = new Students(1, "MARAM", "Ali", 24, 05433055030);
            Students student4 = new Students(1, "Mihad", "Ali", 24, 05433055030);


            m.AddCourses(course1);
            m.AddCourses(course2);


            // m.AddTeacher(t);
            // t.PrintInfo();

            course1.AddStudent(student1);
            course1.AddTeacher(teacher1);
            course1.CoursesInfo();

            course2.AddStudent(student2);
            course2.AddTeacher(teacher2);
            //course2.CoursesInfo();

            course2.AddStudent(student3);
            //course2.AddTeacher(teacher2);
            // course2.CoursesInfo();
            course2.AddStudent(student4);
            course2.CoursesInfo();


            Console.ReadLine();
        }
    }
}
