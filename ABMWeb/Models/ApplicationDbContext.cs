using Microsoft.EntityFrameworkCore;

namespace ABMWeb.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AdminPage> AdminPages { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
    }
}
