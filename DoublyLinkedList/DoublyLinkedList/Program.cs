using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    using System;

    public class Node
    {
        public int Data;
        public Node Next;
        public Node Previous;

        public Node(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class DoublyLinkedList
    {
        private Node Head;
        private Node Tail;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddFront(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
                Console.WriteLine("Head is : "+Head.Data);
                Console.WriteLine("newNode is : " + newNode.Data);

            }
        }

        public void AddRear(int data)
        {
            Node newNode = new Node(data);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail = newNode;
            }
        }

        public void RemoveFront()
        {
            if (Head == null)
                return;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
        }

        public void RemoveRear()
        {
            if (Tail == null)
                return;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
        }

        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddFront(1);
            list.AddFront(2);
            list.AddRear(3);
            list.AddRear(4);

            Console.WriteLine("Doubly Linked List: ");
            list.Display();

            list.RemoveFront();
            list.RemoveRear();

            Console.WriteLine("Doubly Linked List after removing front and rear elements: ");
            list.Display();
            Console.ReadLine();
        }
    }


}
