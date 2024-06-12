using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortsmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 8, 3, 20, 48 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]> arr[j])
                    {
                        // Swap arr[j] and arr[j+1]

                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("---------------");
            foreach (var item in arr)
            {
                Console.WriteLine( item);
            }

            Console.ReadKey();

        }
    }
}
