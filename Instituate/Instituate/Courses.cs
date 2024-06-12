using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituate
{
    internal class Courses
    {
        private string name;
        private double cost;
        private int studentCount;
        private int teacherCount;
        private Students[] studentArray;
        private Teachers[] teacherArray;

        public Courses(string name, double cost)
        {
            this.name = name;
            studentArray = new Students[20];
            teacherArray = new Teachers[10];
            studentCount = 0;
            teacherCount = 0;
            this.cost = cost;
        }

        public void AddStudent(Students s)
        {
            if (studentArray[studentCount]==null)
            {
                studentArray[studentCount++] = s;
            }
            else
            {
                Console.WriteLine("Students array is full. Cannot add more students.");
            }
        }

        public void AddTeacher(Teachers t)
        {
            if (teacherArray[teacherCount]==null)
            {
                teacherArray[teacherCount++] = t;
            }
            else
            {
                Console.WriteLine("Teachers array is full. Cannot add more teachers.");
            }
        }

        public void CoursesInfo()
        {
            Console.WriteLine("-----------------------------------------\n" +
                "Course's Name: " + name + "\n It's cost: " + cost + "\n This Course's Teachers are: ");

            foreach (Teachers teacher in teacherArray)
            {
                if (teacher != null)
                {
                    Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                }
            }

            Console.WriteLine("and Students are: ");

            foreach (Students student in studentArray)
            {
                if (student != null)
                {
                    student.StudentInfo();
                }
            }

             Console.WriteLine("Teacher numbers are : " + teacherCount); 
             Console.WriteLine("Student numbers are : " + studentCount);
        }
    }
}