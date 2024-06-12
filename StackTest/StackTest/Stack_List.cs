using System;

namespace StackTest
{
    class StackItem
    {
        private string name;
        private int age;

  
 
        public string Name{ get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public StackItem(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

    }

    class Stack_List
    {
        private StackItem[] stack;
        private int Count;

        public Stack_List(int size)
        {
            stack = new StackItem[size];
            Count = 0;
        }

        public void Push(StackItem item)
        {
            if (Count < stack.Length)
            {
                stack[Count++] = item; // تعيين العنصر في موقع العدد الحالي
              
            }
            else
            {
                Console.WriteLine("Array is full");
            }
        }
         
        public StackItem Pop() {

            if (Count > 0)
            {
                return stack[--Count];
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }
        }
        public void Display()
        {
            if (Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = Count-1; i >=0; i--)
                {
                    Console.WriteLine("Name : " + stack[i].Name + "\nAge: " + stack[i].Age);
                }
            }
        }
    }
}
