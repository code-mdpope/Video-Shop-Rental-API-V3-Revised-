using Microsoft.EntityFrameworkCore;
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
    }
}
