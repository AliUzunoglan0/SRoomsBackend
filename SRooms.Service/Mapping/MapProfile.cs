using System;
using AutoMapper;
using SRooms.Core;
using SRooms.Core.DTOs;
using SRooms.Core.Models;

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

            CreateMap<Login, LoginDto>().ReverseMap();

        }
	}
}

