using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Veriyapilar
{
    class Factor
    {
        public int[] findfactors(int num, out int numfactors)
        {
            int[] facts = new int[80];
            int i, j;
            for (i = 2, j = 0; i < num / 2 + 1; i++)
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
            numfactors = j;
            return facts;
        }
    }



class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string numstr = num.ToString();
            int length = numstr.Length;
            int[] nums = new int[length];
            string[] tendigits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int index = 0;

            while (num > 0)
            {
                nums[index] = num % 10;
                index++;
                num = num / 10;
            }

            Console.WriteLine("Digits: ");
            for (int i = index - 1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }

            Console.Write("Number in words: ");
            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write(tendigits[nums[i]]);
                if (i > 0)
                {
                    Console.Write(" ");
                }
            }
        
    


    /*
                    // Construct an array with foreach
                    int[] array = new int[4];
                    int sum = 0;
                    double mean = 0;

                    int index = 0;
                    foreach (var item in array)
                    {
                        Console.Write("Enter an integer: ");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        array[index] = tmp;
                        sum += tmp;
                        index++;
                    }

                    mean = (double)sum / array.Length;

                    Console.WriteLine("Elements:");
                    foreach (var arr in array)
                    {
                        Console.WriteLine(arr);
                    }

                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Mean: " + mean);


    */
    /*
              int x=5;
                Console.WriteLine("before : " + x);
           Test1(ref x);
                Console.WriteLine("after : " + x);*/

    /*      Console.WriteLine("---------------------------------\n" +
              "Out test: ");
        //   Console.WriteLine("before : " + x);
           Test2(out x);
           Console.WriteLine("after : " + x);*/


    //Dışarıdan girilen bir sayının çarpanlarını içeren diziyi geri döndüren programı yazınız. findfactors(int num, out int numfactors) metodu tanımlanacak
    Factor f = new Factor();
            int numfactors;
            int[] factors;
            factors = f.findfactors(100, out numfactors);
            /*   Console.WriteLine("numfactor: " + numfactors);
               Console.WriteLine("Factors for 100 are: ");
               for (int i = 0; i < numfactors; i++)
                   Console.Write(factors[i] + " ");
               Console.WriteLine();*/


            //ekok
            /*  int ekok = 0,s1,s2;
              int max= 0;
              Console.WriteLine("1. sayi gir: ");
              s1 = Int16.Parse(Console.ReadLine());
              Console.WriteLine("2. sayi gir: ");
              s2 = Int16.Parse(Console.ReadLine());
              max = s1 * s2;
              for(int i = max; i > 0; i--)
              {
                  if(i%s1==0 && i % s2 == 0)
                  {
                      ekok = i;
                  }
              }
              Console.WriteLine("Ekok: " + ekok);*/

            int sayi, birler;

            sayi = Convert.ToInt32(Console.ReadLine());


    birler = sayi % 10;

            string[] birlik = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            Console.Write(birlik[birler]);

            Console.ReadKey();
        }

        static void Test1(ref int x)
        {
            x = 10;
            Console.WriteLine(x);
        }

        static void Test2(out int x)
        {
            x = 10;
            Console.WriteLine(x);
        }
    }
}
      


