using Microsoft.EntityFrameworkCore;
namespace EntityControllerTest.Models
{
    public class DatabaseClass:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SPO32LR\\SQLEXPRESS;Database=Conrlstest;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
              .HasOne(x=>x.Category)
              .WithMany()
                .HasForeignKey(x => x.CategoryId);
        }

        DbSet<Category> categories { get; set; }
        DbSet<Product> products { get; set; }

    }
}
