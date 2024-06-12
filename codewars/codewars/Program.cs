using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    internal class Program
    {



        /*public static int points(String[] games)
        {
            int win = 0;
            int draw = 0;
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].Equals("4:0") || games[i].Equals("4:1") || games[i].Equals("4:2") || games[i].Equals("4:3"))
                {
                    win++;
                }
                if (games[i].Equals("3:0") || games[i].Equals("3:1") || games[i].Equals("3:2"))
                {
                    win++;
                }
                if (games[i].Equals("2:0") || games[i].Equals("2:1") || games[i].Equals("1:0"))
                {
                    win++;
                }
                if (games[i].Equals("4:4") || games[i].Equals("3:3") || games[i].Equals("2:2") || games[i].Equals("1:1") || games[i].Equals("0:0"))
                {
                    draw++;
                }
            }
            return win * 3 + draw;
        }
*/



        public  int GetSum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;

            }
            if (a != b)
            {
                //Good Luck!
                return sum;
            }

            else
                return a;
        }
    }
    class test
    {

    

    static void Main(string[] args)
        {
            //string [] result = { "4:0" };
            //  Console.WriteLine(points(result));
           Program program = new Program();
            Console.WriteLine(program.GetSum(4,10));
            string name = "Enes Aljahma";
            int devided=name.IndexOf("A");
            Console.WriteLine(devided);
            string lastname = name.Substring(devided);
            Console.WriteLine(lastname);

            
            Console.ReadKey();

        }
    }
}
