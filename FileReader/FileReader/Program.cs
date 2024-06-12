using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("D:\\c#\\Asp.net_Web\\FileReader\\Text.txt");
            /* StreamWriter writer = new StreamWriter("TESTFILE");
             writer.WriteLine(sr.ReadToEnd());
             writer.Close();*/
            string test;
            do
            {
                 test = sr.ReadLine();
                Console.WriteLine(test);

            } while (test != null);

            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
