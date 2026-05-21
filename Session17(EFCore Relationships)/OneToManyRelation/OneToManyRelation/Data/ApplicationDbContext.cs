using Microsoft.EntityFrameworkCore;
using OneToManyRelation.Models;

namespace OneToManyRelation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId);
            
        }
        
    }
}
