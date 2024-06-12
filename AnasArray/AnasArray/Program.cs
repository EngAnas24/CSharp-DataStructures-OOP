using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayNameSpace;

namespace ArrayNameSpace
{
    class StringArray : Collection<string>
    {
        private string[] StrArr;
        private int count;

        public StringArray()
        {
            StrArr = new string[3];
            count = 0;
        }

        public StringArray(int s)
        {
            StrArr = new string[s];
            count = 0;
        }

        public new void Add(string n)
        {
            if (count < StrArr.Length)
            {
                for (int i = 0; i < StrArr.Length; i++)
                {
                    if (string.IsNullOrEmpty(StrArr[i]))
                    {
                        StrArr[i] = n;
                        count++;
                        break;
                    }
                }
            }
            else
            {
                string[] temparr = new string[StrArr.Length + 3];
                Array.Copy(StrArr, temparr, StrArr.Length);
                temparr[StrArr.Length] = n;
                StrArr = temparr;
                count++;
            }
        }

        public void StrPrint()
        {
            for (int i = 0; i < count; i++)
            {
                if (!string.IsNullOrEmpty(StrArr[i]))
                {
                    Console.WriteLine(StrArr[i]);
                }
            }
        }
    }

    class AnasArray : Collection<int>
    {
        int[] arr;
        private int count;

        public AnasArray()
        {
            arr = new int[3];
            count = 0;
        }

        public AnasArray(int s)
        {
            arr = new int[s];
            count = 0;
        }

        public void Add(int n)
        {
            if (count < arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        arr[i] = n;
                        count++;
                        break;
                    }
                }
            }
            else
            {
                int[] temparr = new int[arr.Length + 3];
                Array.Copy(arr, temparr, arr.Length);
                temparr[arr.Length] = n;
                arr = temparr;
                count++;
            }
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AnasArray arr = new AnasArray();
            arr.Add(0);
            arr.Add(2);
            //arr.Print();
            // Create a List of integers
            List<int> numbers = new List<int>(arr);

            // Add elements to the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            // Print the elements in the list
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            StringArray strarr = new StringArray();
            strarr.Add("Anas");
            strarr.Add("Ahmed");
            //strarr.StrPrint();
            List<string> strings = new List<string>(strarr);
            strings.Add("hi");
            strings.AddRange(strarr);

           
            for (int i = 0; i < strings.Count; i++)
            {
                if (!string.IsNullOrEmpty(strings[i]))
                {
                    Console.WriteLine(strings[i]);
                }
            }

            Console.ReadLine();
        
    

        }
    }
}
    