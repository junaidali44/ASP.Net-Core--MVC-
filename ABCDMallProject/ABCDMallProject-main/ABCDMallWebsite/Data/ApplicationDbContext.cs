using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ABCDMallWebsite.Models;

namespace ABCDMallWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FoodCourt> FoodCourts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ========== DECIMAL PRECISION CONFIGURATION ==========

            // Booking - TotalAmount
            builder.Entity<Booking>()
                .Property(b => b.TotalAmount)
                .HasPrecision(18, 2);

            // FoodCourt - AveragePriceForTwo and Rating
            builder.Entity<FoodCourt>()
                .Property(f => f.AveragePriceForTwo)
                .HasPrecision(18, 2);

            builder.Entity<FoodCourt>()
                .Property(f => f.Rating)
                .HasPrecision(3, 2);

            // Movie - Rating and TicketPrice
            builder.Entity<Movie>()
                .Property(m => m.Rating)
                .HasPrecision(3, 1);

            builder.Entity<Movie>()
                .Property(m => m.TicketPrice)
                .HasPrecision(18, 2);

            // Shop - Rating
            builder.Entity<Shop>()
                .Property(s => s.Rating)
                .HasPrecision(3, 2);

            // ========== RELATIONSHIPS CONFIGURATION ==========

            builder.Entity<Booking>()
                .HasOne(b => b.Movie)
                .WithMany()
                .HasForeignKey(b => b.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Feedback>()
                .HasOne(f => f.User)
                .WithMany(u => u.Feedbacks)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            // ========== INDEXES ==========

            builder.Entity<Shop>()
                .HasIndex(s => s.Name)
                .HasDatabaseName("IX_Shops_Name");

            builder.Entity<Shop>()
                .HasIndex(s => s.Category)
                .HasDatabaseName("IX_Shops_Category");

            builder.Entity<Movie>()
                .HasIndex(m => m.Name)
                .HasDatabaseName("IX_Movies_Name");

            builder.Entity<Movie>()
                .HasIndex(m => m.IsNowShowing)
                .HasDatabaseName("IX_Movies_IsNowShowing");

            builder.Entity<Booking>()
                .HasIndex(b => b.BookingReference)
                .HasDatabaseName("IX_Bookings_Reference")
                .IsUnique();
        }
    }
}