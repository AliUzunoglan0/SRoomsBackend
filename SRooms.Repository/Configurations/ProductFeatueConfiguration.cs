using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core;

namespace SRooms.Repository.Configurations
{
	public class ProductFeatueConfiguration : IEntityTypeConfiguration<ProductFeature>
	{
		public ProductFeatueConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);
        }
    }
}

