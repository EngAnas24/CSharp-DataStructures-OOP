using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNodeEnd(1);
            list.AddNodeEnd(2);
            list.AddNodeFirst(3);
            list.RemoveNodeFirst();
            list.RemoveNodeEnd();
            list.Display();
            Console.ReadLine();
        }
    }
}
