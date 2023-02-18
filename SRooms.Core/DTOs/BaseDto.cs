using System;
namespace SRooms.Core.DTOs
{
	public abstract class BaseDto
	{
        public int Id { get; set; }

        public DateTime CreateTime { get; set; }
    }
}

