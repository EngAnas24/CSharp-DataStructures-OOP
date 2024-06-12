using DropdownListTest.Data;
using DropdownListTest.Models;

namespace DropdownListTest.EntityClasses
{
    public class BookEntity : IDatahelper<Book>
    {
        DB data;
        Book book;
        public BookEntity() { 
        data = new DB();
        }
        public void Add(Book table)
        {

           data.Books.Add(table);
            data.SaveChanges();
        }

        public Book Find(int id)
        {
           return data.Books.Where(s => s.Id==id).First();
        }

        public List<Book> GetTables()
        {
            return data.Books.ToList();
        }

        public void Remove(int id)
        {
            book=Find(id);
            data.Books.Remove(book);
            data.SaveChanges();
        }

        public void Update(int id, Book table)
        {
            DB data=new DB();
           data.Books.Update(table);
            data.SaveChanges();

        }
    }
}
