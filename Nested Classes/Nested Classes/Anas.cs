using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nested_Classes
{
    internal class Anas : Ahmed
    {
        public override void speaking()
        {
            Console.WriteLine("Hello Anas ");
        }
        override
        public  void thinking()
        {
            Console.WriteLine("Hi ");
        }
    }
}