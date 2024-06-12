using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using foreach
            /* int[] arr = new int[5];
             int index = 0;
             Console.WriteLine("enter a 5 numbers :");
             foreach (int nums in arr)
             {
                 arr[index] = int.Parse(Console.ReadLine());
                 index++;
             }
             Console.WriteLine("_____________________________");
             foreach (var array in arr)
             {
                 Console.WriteLine(array);
             }

             Console.ReadKey();*/


            //_________________________________
            /*    string name = "ANAS ";
                string jobe = "programming ";
                string age = "25 ";

                string information = String.Format("Name: {0}\n jobe: {1}\n age: {2}\n", name, jobe, age);
                Console.WriteLine(information);

                // buyuk herfleri silmek
                string phrase = "Hi There how r u all ";
                string yeniphrase = "";
                char[] kucuk = new char[phrase.Length];
                kucuk = phrase.ToCharArray();
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (char.IsLower(kucuk[i]))
                    {
                        yeniphrase += kucuk[i];

                    }
                }

                Console.WriteLine(yeniphrase);
                Console.ReadKey(); */


        /*    // pilindirom numbers
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                Console.WriteLine("number : " + n);
                Console.WriteLine("r = " + r);
                sum = (sum * 10) + r;
                Console.WriteLine("sum : " + sum);

                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
            Console.ReadKey();*/
        }

    }
    
}
