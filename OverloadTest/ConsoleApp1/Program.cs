using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperClass3
    {
        public  void ShowValue(int arg)
        {
            Console.WriteLine("SuperClass3 " + arg);
        }

        
    }

    public class SubClass3 : SuperClass3
    {
            

        public void ShowValue(string arg)
        {
            base.ShowValue(10);
            Console.WriteLine("SubClass3 " + arg);
        }

        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SubClass3 sub = new SubClass3();
           sub.ShowValue(20);
            sub.ShowValue("Hi");
            Console.ReadKey();
        }
    }
}
