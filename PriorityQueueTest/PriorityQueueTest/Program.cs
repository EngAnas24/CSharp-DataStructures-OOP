using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace PriorityQueueTest
{
    internal class Person : IComparable<Person>
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person p)
        {
            if (this.age > p.age)
                return -1;
            else if (this.age < p.age)
                return 1;
            else return 0;
        }

        public override string ToString()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PriorityQueue<Person> p = new PriorityQueue<Person>();
            p.Enqueue(new Person("Anas",24));
            p.Enqueue(new Person("Ahmed", 23));
            p.Enqueue(new Person("Ali", 22));
            while (p.Count > 0)
            {
                Console.WriteLine(p.Dequeue());
            }
           
            Console.ReadLine();

        }
    }
}