using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Author
    {
        private string FullName;
        private string Birthpalce;
        private int BirthYear;
        private int DeathYear;
        Book[] BooksArray;

        public Author(string fullName, string birthpalce, int birthYear, int deathYear, int NumOfBooks)
        {
            FullName = fullName;
            Birthpalce = birthpalce;
            BirthYear = birthYear;
            DeathYear = deathYear;
            BooksArray = new Book[NumOfBooks];

        }

        public void AddBook(Book b)
        {
            for (int i = 0; i < BooksArray.Length; i++)
            {
                if (BooksArray[i] == null)
                {
                    BooksArray[i] = b;
                    break;

                }
            }
        }

        public void Print()
        {
            string info = "____________________\n" +
                "Author : " + FullName + "\n" +
                "Birthpalce: " + Birthpalce + "\n" +
                "BirthYear ; " + BirthYear + "\n" +
                "DeathYear: " + DeathYear + "\n" +
                "____________________________";
            Console.WriteLine(info);

            for (int i = 0; i < BooksArray.Length; i++)
            {
                if (BooksArray[i] == null)
                {
                    break;

                }
                // Console.WriteLine(BooksArray[i]);
                BooksArray[i].Display();
            }
        }


    }
}
