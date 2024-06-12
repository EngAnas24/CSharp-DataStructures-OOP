using DropdownListTest.Data;
using DropdownListTest.Models;

namespace DropdownListTest.EntityClasses
{
    public class AuthorEntity : IDatahelper<Author>
    {
        DB db;
        Author author;
        public AuthorEntity() { 
        db = new DB();
        }
        public void Add(Author table)
        {
            db.Authors.Add(table);
            db.SaveChanges();
        }

        public Author Find(int id)
        {
           return db.Authors.Where(x => x.Id==id).First();
        }

        public List<Author> GetTables()
        {
            return db.Authors.ToList();
        }

        public void Remove(int id)
        {
            author = Find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
        }

        public void Update(int id, Author table)
        {
            DB db = new DB();
            db.Authors.Update(table);
            db.SaveChanges();
        }
    }
}
