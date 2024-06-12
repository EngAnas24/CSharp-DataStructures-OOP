using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Classes
{
    internal class Program
    {
      public static void Test(out int num)
        {
            num = 20;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {

            Ahmed ahmed = new Ahmed();
            Anas anas = new Anas();
            int x = 10;
            Console.WriteLine("Before : "+x);

            Test(out x);
            Console.WriteLine("After : " +  x);

            Console.ReadKey();
        }
    }
}
