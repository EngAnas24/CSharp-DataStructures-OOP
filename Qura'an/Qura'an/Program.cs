using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qura_an
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quran quran = new Quran();
            quran.ReadQuranFile("D:\\c#\\Asp.net_Web\\Qura'an\\Qura'an\\quran.txt");
            string r = quran.find("هود");
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
