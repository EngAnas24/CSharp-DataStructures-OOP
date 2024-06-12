using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest
{
    internal class Override1 : OverrideTest//grandson
    {
       

        public  override void test()
        {
            Console.WriteLine("Hey Its Override1 ");
        }
    }
}
