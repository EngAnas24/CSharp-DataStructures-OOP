using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teacher t = new teacher(1, "Ahmet", 23, 100000);
            t.printInfo();
            ComputerEngineer cp = new ComputerEngineer(1,"ANAS",24,1000,"Trendyol");
            cp.printInfo();
            Console.ReadKey();
        }

        }
    }

