using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticTest
{
    public class MyClass//Dad
    {
        public MyClass(bool IsRun = true)
        {
            if (IsRun)
            {
                Console.WriteLine("Hi there");
            }
        }

        public virtual void test()
        {
            Console.WriteLine("Hey Its MyClass ");
        }
    }
}