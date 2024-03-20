using Microsoft.EntityFrameworkCore;
using YourApp.Models;

namespace YourApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
