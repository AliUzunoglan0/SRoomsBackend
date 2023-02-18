using System;
using AutoMapper;
using SRooms.Core;
using SRooms.Core.DTOs;

namespace SRooms.Service.Mapping
{
	public class MapProfile : Profile
	{
		public MapProfile()
		{

			CreateMap<Product, ProductDTO>().ReverseMap();

			CreateMap<Category, CategoryDto>().ReverseMap();

			CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();

			CreateMap<ProductUpdateDto, Product>();

		}
	}
}

