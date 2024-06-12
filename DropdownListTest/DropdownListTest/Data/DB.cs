using Microsoft.EntityFrameworkCore;
using DropdownListTest.Models;
namespace DropdownListTest.Data
{
    public class DB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SPO32LR\\SQLEXPRESS; Database=DBTest; Trusted_Connection=True");
        }

                 public   DbSet<Author>  Authors { get; set; }
                 public DbSet<Book> Books { get; set; }
                 public DbSet<AuthorPost> authorPosts { get; set; }
    }
}
