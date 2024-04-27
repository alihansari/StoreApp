using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.ProductName).IsRequired();
            builder.HasData(
                new Product() { Id = 1, CategoryId = 2,ImageUrl="/images/1.jpg", ProductName = "Computer", Price = 17_000 },
                new Product() { Id = 2, CategoryId = 2,ImageUrl="/images/2.jpg", ProductName = "Keyboard", Price = 1_000 },
                new Product() { Id = 3, CategoryId = 2,ImageUrl="/images/3.jpg", ProductName = "Mouse", Price = 500 },
                new Product() { Id = 4, CategoryId = 2,ImageUrl="/images/4.jpg", ProductName = "Monitor", Price = 7_000 },
                new Product() { Id = 5, CategoryId = 2,ImageUrl="/images/5.jpg", ProductName = "Deck", Price = 17_000 },
                new Product() { Id = 6, CategoryId = 1,ImageUrl="/images/6.jpg", ProductName = "History", Price = 25 },
                new Product() { Id = 7, CategoryId = 1,ImageUrl="/images/7.jpg", ProductName = "Hamlet", Price = 45 }
            );
        }
    }
}