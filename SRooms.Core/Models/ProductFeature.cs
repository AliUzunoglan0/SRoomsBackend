﻿using System;
namespace SRooms.Core
{
	public class ProductFeature
	{
		public int Id { get; set; }

		public string Color { get; set; }

		public int Height { get; set; }

		public int Weight { get; set; }

		public int ProductId { get; set; }

		public Product Product { get; set; }

	}
}
