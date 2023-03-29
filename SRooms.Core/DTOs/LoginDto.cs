using System;
namespace SRooms.Core.DTOs
{
	public class LoginDto : BaseDto
	{
        public int UserId { get; set; }

        public string PhoneNumber { get; set; }

        public string PasswordHash { get; set; }

        public string? VerificationCode { get; set; }

        public int FailedLoginAttempts { get; set; }
    }
}

