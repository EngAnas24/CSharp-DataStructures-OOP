using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPFindimentals
{
    public class Program
    {
        public static void Main()
        {

            //using try,catch, final and throw
            try
            {
                int age = -5;

                Console.WriteLine("Age is: " + age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            try
            {
                int result = Divide(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Finally block executed." + 1 + 2);
            }



            Console.ReadKey();
        }
        static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
    }
}
