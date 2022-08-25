using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DBContextData:DbContext
    {
        public DBContextData()
        {

        }
        public DBContextData(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey(c => c.Id);
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
