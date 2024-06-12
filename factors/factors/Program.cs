using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReturnAnArray
{
    
      
    
    class Program
    {
        public static int[] findfactors(int[] factors, out int numfactors)
        {
            int num = Int16.Parse(Console.ReadLine());
            int i, j;
            for (i = 2, j = 0; i < num / 2 + 1; i++)
                if ((num % i) == 0)
                {
                    factors[j] = i;
                    j++;
                }
            numfactors = j;
            return factors;
        }
        static void Main(string[] args)
        {
            int numfactors;
            int[] factors = new int[100];
            findfactors(factors, out numfactors);
            Console.WriteLine("Factors for 100 are: ");
            for (int i = 0; i < numfactors; i++)
            {
                Console.WriteLine(factors[i]);
            }
            Console.Read();
        }
    }
}
