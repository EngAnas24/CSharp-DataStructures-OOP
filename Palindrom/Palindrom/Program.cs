using System;
namespace Palindrom
{
    class Program
    {
        static bool IsPalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return s.Equals(reversed);
        }

        static string CanMakePalindrome(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                {
                    // Found a pair of mismatched characters
                    char[] swappedArray = s.ToCharArray();
                    char temp = swappedArray[i];
                    swappedArray[i] = swappedArray[length - 1 - i];
                    swappedArray[length - 1 - i] = temp;
                    string swappedString = new string(swappedArray);

                    if (IsPalindrome(swappedString))
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            return "YES"; // If no mismatched pair is found, the string is already a palindrome.
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine().Trim();
            string result = CanMakePalindrome(inputString);
            Console.WriteLine(result);
        }
    }
}