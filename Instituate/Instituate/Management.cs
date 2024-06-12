using Instituate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute
{
    internal class Management
    {
        private int count;
        private Courses[] CrsArr;
        private Teachers[] TchersArr;

        public Management()
        {
            CrsArr = new Courses[5];
            TchersArr = new Teachers[10];
            count = 0;
        }

       /* public void CoursesInfo()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(CrsArr[i]);
            }
        }*/

        /*public void TeachersList()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(TchersArr[i]);
            }
        }*/

        public void AddTeacher(Teachers t)
        {
            
            if (count < TchersArr.Length)
            {
                TchersArr[count++] = t;
            }
            else
            {
                Console.WriteLine("Teachers array is full. Cannot add more teachers.");
            }
        }

        public void AddCourses(Courses c)
        {
            if (count < CrsArr.Length)
            {
                CrsArr[count++] = c;
            }
            else
            {
                Console.WriteLine("Courses array is full. Cannot add more courses.");
            }
        }
    }
}