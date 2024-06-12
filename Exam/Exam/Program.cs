using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        public static int[] Azatlma(int[] nums)
        {
            Random rn = new Random(); 
            foreach(int n in nums)
            {
            int tmp=rn.Next(1,10);
                nums[n] = tmp;
                Console.WriteLine(nums[n]);

            }

          //  int[] num = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

               int n = nums[i] - 1;
                Console.WriteLine(n);
            }


            return nums;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Azatlma(nums);
            Console.ReadLine();
        }
    }
}
