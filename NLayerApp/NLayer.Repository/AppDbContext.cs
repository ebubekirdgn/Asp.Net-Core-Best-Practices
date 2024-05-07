using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());// Reflection yaptık.Bu assembly altındaki IEntityTypeConfiguration interfacesini kim kullandıysa onu al
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id=1,
                Color="Kırmızı",
                Height=100,
                Width=100,
                ProductId=1,
            }, new ProductFeature()
            {
                Id = 2,
                Color = "Mavi",
                Height = 200,
                Width = 150,
                ProductId = 2,
            }

                );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
