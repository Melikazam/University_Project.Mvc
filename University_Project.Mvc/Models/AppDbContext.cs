using Microsoft.EntityFrameworkCore;

namespace University_Project.Mvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }           
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category>Categories { get; set; }

    }
}
