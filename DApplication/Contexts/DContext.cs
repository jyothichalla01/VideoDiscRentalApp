using DApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DApplication.Contexts
{
    public class DContext : DbContext
    {
        public DContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Disc> Discs { get; set; }
        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<Rental> Rentals { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Fluent API
        //    modelBuilder.Entity<Disc>(disc =>
        //    {
        //        disc.HasKey(ck => ck.DiscId);
        //    });
        //    modelBuilder.Entity<Movie>(ci =>
        //    {
        //        ci.HasKey(cik => new { cik.DiscId, cik.MovieId });
        //    });
        //}
    }
}