using DropdownListTest.Data;
using DropdownListTest.Models;

namespace DropdownListTest.EntityClasses
{
    public class AuthorPostEntity : IDatahelper<AuthorPost>
    {
        DB db;
        AuthorPost AuthorPost;
        public AuthorPostEntity() { 
        db = new DB();
        }
        public void Add(AuthorPost table)
        {
            db.authorPosts.Add(table);
            db.SaveChanges();
        }

        public AuthorPost Find(int id)
        {
           return db.authorPosts.Where(x => x.Id==id).First();
        }

        public List<AuthorPost> GetTables()
        {
            return db.authorPosts.ToList();
        }

        public void Remove(int id)
        {
            AuthorPost = Find(id);
            db.authorPosts.Remove(AuthorPost);
            db.SaveChanges();
        }

        public void Update(int id, AuthorPost table)
        {
            DB db = new DB();
            db.authorPosts.Update(table);
            db.SaveChanges();
        }
    }
}
