using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SRooms.Core.Models
{
	public class Login : BaseEntity
	{

        public string PhoneNumber { get; set; }

        public string Token { get; set; }

        public string? VerificationCode { get; set; }

    }
}

