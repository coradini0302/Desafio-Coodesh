using Microsoft.EntityFrameworkCore;
using techChallengeApi.Map;
using techChallengeApi.Model;

namespace techChallengeApi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
        }

        public DbSet<GeneralSales> GeneralSales { get; set; }
        public DbSet<Variety> Varieties { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SellerMap());
            modelBuilder.ApplyConfiguration(new VarietyMap());
            modelBuilder.ApplyConfiguration(new ProductsMap());
            modelBuilder.ApplyConfiguration(new GeneralSalesMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
