using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core;

namespace SRooms.Repository.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public CategoryConfiguration()
		{



		}

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

        }
    }
}

