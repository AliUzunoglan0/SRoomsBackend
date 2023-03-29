using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SRooms.Core;
using SRooms.Core.DTOs;
using SRooms.Core.Models;
using SRooms.Core.Services;

namespace SRooms.Api.Controllers
{
	public class LoginController : BaseController
	{

        private readonly IMapper imapper;
        private readonly IService<Login> service;

        public LoginController(IMapper _imapper, IService<Login> _service)
        {
            this.imapper = _imapper;
            this.service = _service;
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginDto loginDto)
        {
            var loginReq = await service.AddAsync(imapper.Map<Login>(loginDto));

            var loginResponseDto = imapper.Map<LoginDto>(loginReq);

            return CreateActionResult<LoginDto>(CustomResponseDto<LoginDto>.Success(200, loginResponseDto));

        }


    }
}

