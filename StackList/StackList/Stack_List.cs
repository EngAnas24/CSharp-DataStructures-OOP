using System;

namespace Stack_List
{
    class StackList<T>
    {
        public T[] stack;
        private int count;

        public T[] Stack { get => stack; set => stack = value; }

        public StackList(int Size)
        {
            Stack = new T[Size]; 
        }

        public void Push(T item)
        {
            if (count < Stack.Length)
            {
                Stack[count++] = item;
            }
            else
            {
                Console.WriteLine("Stack is full.");
            }
        }

        public int Pop()
        {
            if (count <= 0)
            {
                Console.WriteLine("Stack overflow");
                return count;
            }
            else
            {
                int number =count;
                count--;
                return number;
            }
        }
        public bool IsEmpty()
        {
            if (count <= 0)
            {
                return true;
            }
            else { return false; }
        }
        public void Display()
        {
            if (count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    Console.WriteLine(Stack[i] + "\n");
                }
            }
        }
    }
}