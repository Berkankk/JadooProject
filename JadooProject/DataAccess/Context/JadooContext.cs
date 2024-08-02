using JadooProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.DataAccess.Context
{
    public class JadooContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JBL3A9M\\SQLEXPRESS;database=JadooProjectDb;integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Manuel> Manuels { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
