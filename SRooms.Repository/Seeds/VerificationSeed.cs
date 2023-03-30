using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core.Models;

namespace SRooms.Repository.Seeds
{
    public class VerificationSeed : IEntityTypeConfiguration<Verification>
    {
        public void Configure(EntityTypeBuilder<Verification> builder)
        {
            builder.HasData(
                new Verification()
                {
                    Id = 1,
                    PhoneNumber = "5377110446",
                    VerificationCode = "bauz",
                    CreateTime = DateTime.Now
                });
        }
    }
}

