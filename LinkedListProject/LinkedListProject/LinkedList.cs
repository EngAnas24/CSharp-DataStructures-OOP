using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    internal class LinkedList
    {
        private Node Head,Tail;

        public  LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNodeEnd(double val)
        {
            Node item = new Node(val);
            if(Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
               
                Tail.Next = item; 
                Tail = item;
            }
        }
        public void AddNodeFirst(double val)
        {
            Node item = new Node(val);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {

                item.Next = Head;
                Head = item;
            }
        }
        public void RemoveNodeFirst()
        {
            int count=0;
            if (Head == null)
            {
                Tail = null;
            }
            else
            {
                for(int i = 0; i <= count; i++)
                {
                    Node Start = Head;
                    Start = null;
                    Start = Head.Next;
                    Head = Start;
                }
                count++;

            }
        }
         public void RemoveNodeEnd()
          {
              if (Head == null)
              {
                  Console.WriteLine("List is empty");
                  return;
              }
              else if (Head == Tail)
              {
                  Head = null;
                  Tail = null;
              }
              else
              {
                  Node previous = null;
                  Node current = Head;

                  while (current.Next != null)
                  {
                      previous = current;
                      current = current.Next;
                  }

                  Tail = previous;
                  Tail.Next = null;
              }
          }

       
        public void Display()
        {
            Node start = Head;

            if (start == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (start != null)
                {
                    Console.WriteLine(start.Data);
                    start = start.Next;
                }
            }
        }
      
    }
}
