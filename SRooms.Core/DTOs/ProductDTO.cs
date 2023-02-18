using System;
namespace SRooms.Core.DTOs
{
	public class ProductDTO : BaseDto
	{
        public new int Id { get; set; }

        public string? Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }
    }
}

