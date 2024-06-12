using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new Override2();
            MyClass myClass1 = new Override1();

            myClass.test();
            myClass1.test();


            Console.ReadLine();
        }
    }
}
