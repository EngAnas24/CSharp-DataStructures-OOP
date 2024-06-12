
using Microsoft.VisualBasic;
using System;
class HelloWorld
{
    public static int SquareSum(int[] numbers)
    {
        int c = 1, sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= numbers[i];
            sum += numbers[i];
            Console.WriteLine("Array's number: " + numbers[i]);

        }
        Console.WriteLine("Sum = " + sum);
        return sum;
    }
    public static string BoolToString(bool b)
    {
        return b.ToString();
    }



    static void Main()
    {
        int[] nums = { 1, 3, 5, 8, 7 };
    //    SquareSum(nums);

        // Example usage:
        bool boolValue = true;
        string stringRepresentation = BoolToString(boolValue);
        Console.WriteLine(stringRepresentation); // This will print "True"
        string str1 = "Katherine";
        string str2 = "PQRS";
        Console.WriteLine("String1 = " + str1);
        Console.WriteLine("String1 ToUpperInvariant = " + str1.ToUpperInvariant());
        Console.WriteLine("String1 Substring from index4 = " + str1.Substring(4));
        Console.WriteLine("String2 = "+str2);


        Console.WriteLine("String2 ToUpperInvariant = " + str2.ToLowerInvariant());
        Console.WriteLine("String2 Substring from index2 = " + str2.Substring(2));
        Console.ReadKey();
    }
}