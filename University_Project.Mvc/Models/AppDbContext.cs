using Microsoft.EntityFrameworkCore;

namespace University_Project.Mvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Car> Cars { get; set; }
    }
}
