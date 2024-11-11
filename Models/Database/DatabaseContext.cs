using Microsoft.EntityFrameworkCore;
using SMe.Models.Domains;

namespace SMe.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Store> Stores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>(entity => {
                entity.HasKey(e => e.PK_iStoreID);
            });
        }
    }
}
