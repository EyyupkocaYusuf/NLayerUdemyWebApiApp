using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature
            {
                Id = 1,
                ProductId = 1,
                Color="Kırmızı",
                Width = 500,
                Height = 300,
            },
            new ProductFeature
            {
                Id = 2,
                ProductId = 2,
                Color = "Mavi",
                Width = 500,
                Height = 300,
            });
        }
    }
}
