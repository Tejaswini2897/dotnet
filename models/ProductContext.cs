using Microsoft.EntityFrameworkCore;

namespace ProductSupplierAPIs.models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Supplier>(entity => {
                entity.ToTable("Product");
            });
        }
        public DbSet<Product> ProductItems { get; set; } = null!;
    }
}
