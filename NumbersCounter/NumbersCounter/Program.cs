using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NumbersCounter
{
    public class Program
    {
        static void Main(string[] args)
        {

        /*    //Asal Sayıyı Bulma
            int[] Asalsayilar = new int[50];
            int count = 0;

            for (int i = 2; count < 50; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Asalsayilar[count] = i;
                    count++;
                }
            }

            foreach (var prime in Asalsayilar)
            {
                Console.WriteLine(prime);
            }

            int vize, final, ort;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50 || final < 50)
                Console.WriteLine("Kaldınız.");
            else
                Console.WriteLine("Geçtiniz.");*/


            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            /* bool sonuc = Asalmi(sayi);
             if (sonuc == true)
             {
                 Console.WriteLine("{0} Asal Sayı Değildir.", sayi);
             }
             else
             {
                 Console.WriteLine("{0} Asal Sayıdır.", sayi);
             }*/

            int count = 0;
          for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.Write("Asal sayi");
            }
            else
                Console.Write("Asal sayi degil");

            Console.ReadKey();
        }

        /*private static bool Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return true;
                }
            }
            if (i == sayi)
            {
                return false;
            }
            return false;
        }*/




    }
}
