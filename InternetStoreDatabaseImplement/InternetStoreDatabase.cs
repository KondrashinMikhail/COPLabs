using InternetStoreDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreDatabaseImplement
{
    public class InternetStoreDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=InternetStoreDatabase;Username=postgres;Password=MK");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
