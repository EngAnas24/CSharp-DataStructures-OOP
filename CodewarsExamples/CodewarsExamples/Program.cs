/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace CodewarsExamples
{
    public class Program
    {


        *//*   static void Main(string[] args)
           {
               string[] strings = { "hello", "world", "open", "ai" };
               string result = SortAndReturnFirst(strings);
               Console.WriteLine(result);

               Console.ReadLine(); 
           }

           static string SortAndReturnFirst(string[] strings)
           {
               // Bubble sort
               for (int i = 0; i < strings.Length - 1; i++)
               {
                   for (int j = 0; j < strings.Length - i - 1; j++)
                   {
                       if (CompareStrings(strings[j], strings[j + 1]) > 0)
                       {
                           // Swap strings
                           string temp = strings[j];
                           strings[j] = strings[j + 1];
                           strings[j + 1] = temp;
                       }
                   }
               }

               // Retrieve the first sorted string
               string firstWord = strings[0];

               // Join characters with "***"
               string joinedString = "";
               foreach (char c in firstWord)
               {
                   joinedString += c + "***";
               }

               // Remove the extra "***" at the end
               joinedString = joinedString.Substring(0, joinedString.Length-3) ;

               return joinedString;
           }

           // Custom string comparison function based on ASCII values
           static int CompareStrings(string str1, string str2)
           {
               for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
               {
                   if (str1[i] != str2[i])
                   {
                       return str1[i] - str2[i];
                   }
               }
               return str1.Length - str2.Length;
           }
       */



/*   public static void Main()
   {
       int[] arr = { 1, 2, 3, 4, 6, 7, 8 };
       int consecutiveNum = 0;

           for (int j = 0; j < arr.Length; j++)
           {
               if (j + 1 != arr[j])
               {
               consecutiveNum = arr[j];
               break;
               }

       }
       Console.WriteLine(consecutiveNum);
       Console.ReadLine();
   }*/

/* public static void Main(string[] args)
 {
     // Example usage
     Console.WriteLine(CountSheep(3)); // Output: "1 sheep...2 sheep...3 sheep..."
     Console.WriteLine(CountSheep(5)); // Output: "1 sheep...2 sheep...3 sheep...4 sheep...5 sheep..."
     string sumstr = "";
     int num1 = 1; int num2 =2;
     sumstr = num2.ToString()+num1;

     Console.WriteLine(sumstr);

     Console.ReadKey();


 }
 public static string CountSheep(int num)
 {
     string murmur = "";

     // Generate the murmur string by counting sheep up to the given number
     for (int i = 1; i <= num; i++)
     {
         murmur += i + " sheep...";
     }

     return murmur;
 }
*/




/*public static void Main()
{
    string text = "5T4CK 0V3RF10W";
    string correctedText = CorrectErrors(text);
    Console.WriteLine(correctedText); // Output: "STACK OVERFLOW"
    Console.ReadLine();
}

public static string CorrectErrors(string text)
{
    // Replace misinterpreted characters with correct ones
    text = text.Replace('5', 'S').Replace('0', 'O').Replace('1', 'I');

    return text;
}
*/


/*public static double polygon(double width,double height)
{
    if(width==height)
        return width*height;
    else
        return (height +width)*2;
}

public static void Main(string[] args)
{

    double test= polygon(10,10);
    Console.WriteLine(test);

    Console.ReadLine();
}
*/


/* public static void Main()
 {
     string[] strings1 = { "keep", "remove", "keep", "remove", "keep", "remove", "keep", "remove" };
     string[] strings2 = new string[(strings1.Length) / 2]; // Adjust the length of strings2
     Console.WriteLine(strings1.Length);
     int j = 0; // Use a separate index for strings2

     for (int i = 0; i < strings1.Length; i += 2) // Increment by 2 to skip every other element
     {
         strings2[j] = strings1[i];
         j++; // Increment the index for strings2
     }

     foreach (string s in strings2)
     {
         Console.WriteLine(s);
     }

     Console.ReadLine();
 }*/


/* public static void Main(string[] args)
 {
     string[] words = { "hello", "world", "this", "is", "great" };
     string result = Smash(words);
     Console.WriteLine(result); // Output: hello world this is great
     Console.ReadLine();
 }

 public static string Smash(string[] words)
 {
     return string.Join(" ", words);
 }*/



/*   public static int NoBoringZeros(int n)
   {
       // If n is zero, return it directly
       if (n == 0)
           return 0;

       // Remove trailing zeros by dividing by 10 until the last digit is not zero
       while (n % 10 == 0)
       {

           n /= 10;

       }

       return n;
   }


   public static double ConvertToDouble(int n)
   {
       return (double)n;
   }
   public static bool IsUpperCase(this string text)
   {

       char[] chars = text.ToCharArray(); ;
       foreach (char c in chars) {
           if (char.IsUpper(c))
           {
               return true;
           }
           return false;
       }
     return false;
   }*//*



   public static int[] PowersOfTwo(int n)
   {
       // تعريف مصفوفة لتخزين النتائج بطول n+1
       int[] result = new int[n + 1];

       // حساب القوى وتخزينها في المصفوفة
       for (int i = 0; i <= n; i++)
       {
           result[i] =(int) Math.Pow(2, i);
       }

       // إرجاع المصفوفة
       return result;
   }

   static void Main()
   {
       // تجربة الدالة PowersOfTwo وعرض النتائج
       int n = 10; // يمكنك تغيير هذه القيمة لتجربة أخرى
       int[] powers = PowersOfTwo(n);

       Console.WriteLine("Powers of 2 up to 2^" + n + ":");
       foreach (var power in powers)
       {
           Console.WriteLine(power);
       }

       // انتظار المستخدم للضغط على مفتاح لإنهاء البرنامج
       Console.ReadKey();
   }





}
}
*/

using System;

public class Kata
{
    public static int RoundToNext5(int n)
    {
        int remainder = n % 5;
        if (remainder == 0)
        {
            return n;
        }
        return n + (5 - remainder);
    }


    public static string GetMiddle(string s)
    {
        int Index = 0;
        if (s.Length % 2 == 0)
        {
            Index = s.Length / 2;

        }
        if (s.Length % 2 == 1)
        {
            Index = (s.Length - 1) / 2;
        }
        return s[Index].ToString();

    }

    public static void Main(string[] args)
    {
        /*// Test cases
        int[] testValues = { 0, 2, 3, 12, 21, 30, -2, -5 };

        Console.WriteLine("Input\t->\tOutput");
        foreach (int value in testValues)
        {
            int result = RoundToNext5(value);
            Console.WriteLine($"{value}\t->\t{result}");
        }*/

        // Test cases
        string[] testValues = { "test", "testing", "middle", "A" };

        Console.WriteLine("Input\t\t->\tOutput");
        foreach (string value in testValues)
        {
            string result = GetMiddle(value);
            Console.WriteLine($"{value}\t\t->\t{result}");
        }

        Console.ReadLine();
    }
}

