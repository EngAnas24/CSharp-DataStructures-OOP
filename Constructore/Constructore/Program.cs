using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Constructore
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Student student1 = new Student(20, 90);
            Student student2 = new Student(23, 94);
            Student student3 = new Student(24, 99);
            Student student4 = new Student(25, 100);
            //  student2.Print();
            //  student2.Print();
            Group g1 = new Group(student1, student2);
            Group g2 = new Group(student3, student4);
            g1.Print();
            g2.Print();
            /*Console.WriteLine(""+student1.GetType().FullName);
            Console.WriteLine("" + student1.GetType().FullName);
            Console.WriteLine("" + student3.GetType().FullName);
            Console.WriteLine("" + g2.GetType().FullName);*/


            Console.ReadKey();
        }
    }
}
