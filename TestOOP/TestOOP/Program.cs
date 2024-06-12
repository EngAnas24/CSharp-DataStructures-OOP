using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authors Anas = new Authors("Anas",0);
            Authors Ahmed = new Authors("Ahmed", 0);
            Authors mohammed = new Authors("mohammed", 0);

            Anas.AddAuthor(Anas);
            Anas.Print();
            Ahmed.AddAuthor(Anas);
            Ahmed.Print();
            Console.ReadKey();
        }
    }
}
