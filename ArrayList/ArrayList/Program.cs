// C# program to illustrate the
// Capacity Property of List<T>
using System;
using System.Collections.Generic;

class Geeks
{

    // Main Method
    public static void Main(String[] args)
    {

        // Creating a List of integers
        // Here we are not setting
        // Capacity explicitly
        List<int> firstlist = new List<int>();
        List<int> list = new List<int>();
        // adding elements in firstlist
        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(4);

        // Printing the Capacity of firstlist
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);

        // Adding some more
        // elements in firstlist
        firstlist.Add(5);
        firstlist.Add(6);


        // Printing the Capacity of firstlist
        // It will give output 8 as internally
        // List is resized
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);
        Console.WriteLine(firstlist.Contains(6));


        List<int> myList = new List<int> { 1, 2, 3 };
        int[] newArray = { 4, 5, 6 };

        myList.AddRange(newArray);
        myList.
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}
