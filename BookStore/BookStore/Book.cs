using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        private string BookName;
        private string BookClass;

        public Book(string bookName, string bookClass)
        {
            BookName = bookName;
            BookClass = bookClass;
        }



        public void Display()
        {
            string info = "______________________\n" +
            "Book Name is : " + BookName + "\n" +
            "Book Class is : " + BookClass + "\n" +
            "___________________________-";
            Console.WriteLine(info);
        }

    }
}
