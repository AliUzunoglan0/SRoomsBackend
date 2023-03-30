using System;
namespace SRooms.Core.DTOs
{
	public class LoginDto : BaseDto
	{

        public string PhoneNumber { get; set; }

        public string Token { get; set; }

        public string? VerificationCode { get; set; }

    }
}

