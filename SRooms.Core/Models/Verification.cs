using System;
namespace SRooms.Core.Models
{
	public class Verification: BaseEntity
	{
        public string PhoneNumber { get; set; }

        public string VerificationCode { get; set; }

        public DateTime ExpirationTime { get; set; }
    }
}

