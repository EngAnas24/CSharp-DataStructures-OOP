using System;
namespace Questions{
    class Program
    {
       /* public static void DecreaseArray(int[] arr, int index)
        {
            // Baz durum: Tüm elemanlar azaltıldıktan sonra rekürsiyonu sonlandır
            if (index == arr.Length)
            {
                return;
            }

            // Mevcut elemanı 1 azalt
            arr[index]--;

            // Sonraki elemana geçmek için rekürsif çağrı yap
            DecreaseArray(arr, index + 1);
        }
*/


    
        static string GetLowerCaseChars(string input)
        {
            string lowerCaseChars = string.Empty;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    lowerCaseChars += c; // إضافة الحرف الصغير إلى السلسلة المؤقتة
                }
            }

            return lowerCaseChars;
        }

       
    
    static void Main(string[] args)
        {
            /*  // Ornek bir dizi
              int[] numbers = { 5, 8, 3, 2, 9, 6, 1, 4, 7, 0 };

              Console.WriteLine("Dizi Öncesi: " + string.Join(", ", numbers));

              // Fonksiyonu çağırarak diziyi azalt
              DecreaseArray(numbers, 0);

              Console.WriteLine("Dizi Sonrası: " + string.Join(", ", numbers));*/
            Console.Write("من فضلك، أدخل سلسلة نصية: ");
            string input = Console.ReadLine();

            string result = GetLowerCaseChars(input);
            Console.WriteLine("الأحرف الصغيرة في السلسلة: " + result);
        }
    }
}
