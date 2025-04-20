using Microsoft.EntityFrameworkCore;

namespace MyTasksWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Tasks> Task { get; set; }

    }
}
