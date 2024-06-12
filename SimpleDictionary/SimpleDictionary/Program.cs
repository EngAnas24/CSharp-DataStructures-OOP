using System;
using System.Collections;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("هلا");
        set.Add("حيا");
        set.Add("مرحبا");

        Dictionary<string, HashSet<string>> dic = new Dictionary<string, HashSet<string>>();
        Console.WriteLine("Enter the word you want to search for:");
        string wordKey = Console.ReadLine();
        dic.Add(wordKey, set);

        // Accessing and printing the HashSet stored in the Dictionary using IEnumerator
        Console.WriteLine("HashSet stored in the Dictionary:");

        /* IEnumerator<string> enumerator = dic[wordKey].GetEnumerator();
         while (enumerator.MoveNext())
         {
             string value = enumerator.Current;
             Console.WriteLine(value);
         }*/
        ISet<string> values = dic[wordKey];
        IEnumerator<string> enumerator = values.GetEnumerator();
        while (enumerator.MoveNext())
        {
            string value = enumerator.Current;
            Console.WriteLine(value);
        }

        ICollection<string> v = dic.Keys;
        IEnumerator<string> m = v.GetEnumerator();
        while (m.MoveNext())
        {
            Console.WriteLine(m.Current);
        }

        Console.WriteLine("");
        Console.ReadLine();
    }
}