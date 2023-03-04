using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SRooms.Core;
using SRooms.Core.DTOs;
using SRooms.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SRooms.Api.Controllers
{
    
    public class ProductsController : BaseController
    {

        private readonly IMapper imapper;
        private readonly IService<Product> service;

        public ProductsController(IMapper imapper, IService<Product> service)
        {
            this.imapper = imapper;
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await service.GetAllAsync();

            var productDtos = imapper.Map<List<ProductDTO>>(products.ToList());
                      
            return CreateActionResult<List<ProductDTO>>(CustomResponseDto<List<ProductDTO>>.Success(200, productDtos));

        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await service.GetByIdAsync(id);

            var productDto = imapper.Map<ProductDTO>(product);

            return CreateActionResult<ProductDTO>(CustomResponseDto<ProductDTO>.Success(200, productDto));

        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductDTO productDto)
        {
            var product = await service.AddAsync(imapper.Map<Product>(productDto));

            var productsDto = imapper.Map<ProductDTO>(productDto);

            return CreateActionResult<ProductDTO>(CustomResponseDto<ProductDTO>.Success(200, productsDto));

        }


        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productDto)
        {
            await service.UpdateAsync(imapper.Map<Product>(productDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("id")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await service.GetByIdAsync(id);

            await service.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


    }
}

