using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest
{
    public  class OverrideTest:MyClass//Son 
                                      //Override1's Dad
    {
        public OverrideTest():base(false) { 
        }
        public override void test()
        {
            Console.WriteLine("Hey Its OverrideTest");
        }
        
    }
}
