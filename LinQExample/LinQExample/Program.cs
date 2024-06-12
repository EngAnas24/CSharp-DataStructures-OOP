using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // تعريف مصفوفة تحتوي على الأرقام
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // استخدام foreach loop لطباعة كل عنصر في المصفوفة
            Console.WriteLine("ForEach Loop:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // استخدام ToList() لتحويل المصفوفة إلى List<int>
            List<int> numbersList = numbers.ToList();

            // استخدام Count() للحصول على عدد العناصر في List<int>
            Console.WriteLine($"Count: {numbersList.Count}");

            // استخدام FirstOrDefault() للحصول على أول عنصر أكبر من 5
            var firstGreaterThanFive = numbersList.FirstOrDefault(n => n > 5);
            Console.WriteLine($"First Greater Than 5: {firstGreaterThanFive}");

            // استخدام Where() للحصول على العناصر التي أكبر من 5
            var numbersGreaterThanFive = numbersList.Where(n => n > 5);
            Console.WriteLine("Numbers Greater Than 5:");
            foreach (var num in numbersGreaterThanFive)
            {
                Console.WriteLine(num);
            }

            // استخدام OrderBy() لترتيب الأرقام بشكل تصاعدي
            var sortedNumbers = numbersList.OrderBy(n => n);
            Console.WriteLine("Sorted Numbers:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }

            // استخدام Select() لضرب كل عنصر في 2 وطباعة النتائج
            var multipliedNumbers = numbersList.Select(n => n * 2);
            Console.WriteLine("Multiplied Numbers:");
            foreach (var num in multipliedNumbers)
            {
                Console.WriteLine(num);
            }

            // استخدام Any() للتحقق مما إذا كانت هناك أي أرقام فردية في List<int>
            var hasOddNumbers = numbersList.Any(n => n % 2 != 0);
            Console.WriteLine($"Has Odd Numbers: {hasOddNumbers}");

            // استخدام Sum() للحصول على مجموع الأرقام في List<int>
            var sumOfNumbers = numbersList.Sum();
            Console.WriteLine($"Sum of Numbers: {sumOfNumbers}");

            // استخدام Average() للحصول على متوسط الأرقام في List<int>
            var averageOfNumbers = numbersList.Average();
            Console.WriteLine($"Average of Numbers: {averageOfNumbers}");

            // استخدام Min() للحصول على أصغر عنصر في List<int>
            var minNumber = numbersList.Min();
            Console.WriteLine($"Minimum Number: {minNumber}");

            // استخدام Max() للحصول على أكبر عنصر في List<int>
            var maxNumber = numbersList.Max();
            Console.WriteLine($"Maximum Number: {maxNumber}");

            // الانتظار لعرض النتائج
            Console.ReadLine();
        }
    }
}
