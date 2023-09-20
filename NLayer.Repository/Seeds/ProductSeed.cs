using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalemler 1",
                Price = 100,
                Stock = 10,
                CreatedDate = DateTime.Now
            },
                 new Product
                 {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Kalemler 2",
                     Price = 200,
                     Stock = 20,
                     CreatedDate = DateTime.Now
                 },
                  new Product
                  {
                      Id = 3,
                      CategoryId = 1,
                      Name = "Kalemler 3",
                      Price = 300,
                      Stock = 30,
                      CreatedDate = DateTime.Now
                  },
                   new Product
                   {
                       Id = 4,
                       CategoryId = 2,
                       Name = "Kalemler 4",
                       Price = 400,
                       Stock = 40,
                       CreatedDate = DateTime.Now
                   },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 3,
                        Name = "Kalemler 5",
                        Price = 500,
                        Stock = 50,
                        CreatedDate = DateTime.Now
                    });
        }
    }
}
