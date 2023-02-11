using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core;

namespace SRooms.Repository.Seeds
{
	public class ProductSeed : IEntityTypeConfiguration<Product>
    {
		public ProductSeed()
		{
		}

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Tukenmez Kalem",
                    CategoryId = 1,
                    Price = 200,
                    Stock = 20,
                    CreateTime = DateTime.Now
                },

                new Product()
                {
                    Id = 2,
                    Name = "Çalışma Kitabı",
                    CategoryId = 2,
                    Price = 300,
                    Stock = 10,
                    CreateTime = DateTime.Now
                },

                new Product()
                {
                    Id = 3,
                    Name = "Çizgili Defter",
                    CategoryId = 3,
                    Price = 150,
                    Stock = 15,
                    CreateTime = DateTime.Now
                });
        }
    }
}

