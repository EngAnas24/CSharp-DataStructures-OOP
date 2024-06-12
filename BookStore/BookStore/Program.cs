using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book("");
            Author Shafei = new Author("محمد بن ادريس الشافعي", "فلسطين غزة", 150, 204, 2);
            Author jalal = new Author("جلال الدين السيوطي", "مصر -اسيوط", 849, 911, 2);

            Book um = new Book("الأم", " الفقه");
            Book resalah = new Book("الرسالة", "أصول الفقه");

            Book etgan = new Book("الإتقان في علوم القرأن", " علوم القران");
            Book ashbah = new Book("الأشباه والنظائر", "النحو");

            Shafei.AddBook(um);
            Shafei.AddBook(resalah);

            jalal.AddBook(etgan);
            jalal.AddBook(ashbah);

            Shafei.Print();
            Console.WriteLine("_________________________");
            jalal.Print();

            Console.ReadKey();

        }
    }
}
