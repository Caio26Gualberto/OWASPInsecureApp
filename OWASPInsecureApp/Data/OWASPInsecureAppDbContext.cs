using Microsoft.EntityFrameworkCore;
using OWASPInsecureApp.Models;

namespace OWASPInsecureApp.Data
{
    public class OWASPInsecureAppDbContext : DbContext
    {
        public OWASPInsecureAppDbContext(DbContextOptions<OWASPInsecureAppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData
            (
                new User { Id = 1, Username = "admin", Password = "admin123" },
                new User { Id = 2, Username = "caio", Password = "caio123" }
            );
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Comment> Comments => Set<Comment>();
    }
}

