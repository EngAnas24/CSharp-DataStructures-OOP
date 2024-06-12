using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_List stack = new Stack_List(4);
            StackItem item = new StackItem("Anas",24);
            stack.Push(item);
            stack.Display();
            Console.ReadKey();
        }
    }
}
