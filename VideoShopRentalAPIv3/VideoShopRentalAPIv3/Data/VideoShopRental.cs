using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VideoShopRentalAPIv3.Models;

namespace VideoShopRentalAPIv3.Data
{
    public class VideoRentalContext : DbContext
    {
        public VideoRentalContext(DbContextOptions<VideoRentalContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalDetails> RentalDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.ReleaseDate)
                    .IsRequired();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(100);
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.RentalDate)
                    .IsRequired();
                entity.Property(e => e.ReturnDate)
            .IsRequired();

            });

            modelBuilder.Entity<RentalDetails>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.RentalId)
                    .IsRequired();
                entity.Property(e => e.MovieId)
                    .IsRequired();

            });
        }
    }
}
