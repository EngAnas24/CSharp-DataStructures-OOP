using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest
{
    class Override2 : MyClass//Son
    {
       
        public new void test()
        {
            Console.WriteLine("Hey Its Override2 ");
        }

    }
}
