using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAdvice
{

   

    class Program
    {
        static void Main(string[] args)
        {
            MobileDevice device1 = new MobileDevice("Apple", 6.1, 128);
            device1.DisplayInfo();

            MobileDevice device2 = new MobileDevice("Samsung", 6.5, 256);
            device2.DisplayInfo();

            device1.ChangeBrand("Google");
            device1.DisplayInfo();
            Console.ReadKey();
        }
    }

}
