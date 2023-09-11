using Microsoft.EntityFrameworkCore;

namespace ProductSupplierAPIs.models
{
    public class SuppilerContext : DbContext
    {
        public SuppilerContext(DbContextOptions<SuppilerContext> options) : base(options)
        {
        }
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // configures one-to-many relationship
            modelBuilder.Entity<Supplier>()
                .HasRequired<Product>(s => s.Products)
                .WithMany(g => g.Supplier)
                .HasForeignKey<int>(s => s.Products);
        }
*/
        public DbSet<Supplier> SuppliersItems { get; set; } = null!;
    }
}
