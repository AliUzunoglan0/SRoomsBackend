﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core;

namespace SRooms.Repository.Seeds
{
	public class CategorySeed : IEntityTypeConfiguration<Category>
    {
		public CategorySeed()
		{
		}

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category() { Id = 1, Name = "Kalemler" },
                new Category() { Id = 2, Name = "Kitaplar" },
                new Category() { Id = 3, Name = "Defterler" });
        }
    }
}

