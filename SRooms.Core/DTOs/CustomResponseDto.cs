using System;
using System.Text.Json.Serialization;

namespace SRooms.Core.DTOs
{
	public class CustomResponseDto<T>
	{

		public T Data { get; set; }

		public List<String> Errors { get; set; }

		[JsonIgnore]
		public int StatusCode { get; set; }


	}
}

