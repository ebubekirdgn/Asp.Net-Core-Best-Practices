using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.SeedData
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, CategoryId = 1, Name = "Faber Castel", Price = 50, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 2, CategoryId = 2, Name = "Robin Hood", Price = 70, Stock = 100, CreatedDate = DateTime.Now },
                new Product() { Id = 3, CategoryId = 3, Name = "Lila Kağıt", Price = 80, Stock = 200, CreatedDate = DateTime.Now }

                );


        }
    }
}
