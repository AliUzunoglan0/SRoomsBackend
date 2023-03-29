using System;
namespace SRooms.Core.Models
{
	public class Login : BaseEntity
	{
        public int UserId { get; set; }

        public string PhoneNumber { get; set; }

        public string PasswordHash { get; set; }

        public string? VerificationCode { get; set; }

        public int FailedLoginAttempts { get; set; }
    }
}

