using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricForms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CIrcle cIrcle = new CIrcle(2);
            Rectangul rectangul = new Rectangul(5,4);  
            //cIrcle.SetRaduis(3);
            Console.WriteLine(cIrcle.GetArea());
            Console.WriteLine(cIrcle.GetParimeter());
            Console.WriteLine(rectangul.GetArea());
            Console.WriteLine(rectangul.GetParimeter());

            Console.ReadLine();
        }
    }
    
}
