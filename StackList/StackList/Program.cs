using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackList<char> Stack = new StackList<char>(5);

            /*Stack.Push(5);
            Stack.Push(6);
            Stack.Push(7);
            Stack.Pop();
            Console.WriteLine(Stack.IsEmpty());
            Console.WriteLine(Stack.stack[Stack.Pop()]);*/
            //Stack.Display();
            RvrsStr("ANAS");
            Console.ReadKey();
        }


        static void RvrsStr(string str) 
        {
            StackList<char> test = new StackList<char>(str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                char krktr = str[i];
                test.Push(krktr);
            }
            test.Display();

        }
    }
}
