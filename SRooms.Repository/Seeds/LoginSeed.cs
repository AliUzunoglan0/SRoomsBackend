using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SRooms.Core;
using SRooms.Core.Models;

namespace SRooms.Repository.Seeds
{
	public class LoginSeed : IEntityTypeConfiguration<Login>
	{
		public LoginSeed()
		{
		}

        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasData(
                new Login()
                {
                    Id = 1,
                    UserId = 4444,
                    PhoneNumber = "5377110446",
                    PasswordHash = "alitayyip",
                    VerificationCode = "bauz",
                    CreateTime = DateTime.Now
                });
        }
    }
    
}

