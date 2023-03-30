using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SRooms.Core;
using SRooms.Core.DTOs;
using SRooms.Core.Models;
using SRooms.Core.Services;

namespace SRooms.Api.Controllers
{
	public class LoginController : BaseController
	{

        private readonly IMapper imapper;
        private readonly IService<Login> loginService;
        private readonly IService<Verification> verificationService;

        public LoginController(IMapper _imapper, IService<Login> _loginService, IService<Verification> _verificationService)
        {
            this.imapper = _imapper;
            this.loginService = _loginService;
            this.verificationService = _verificationService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            if(loginDto.VerificationCode == null)
            {
                Random random = new Random();
                int verificationCode = random.Next(100000, 999999);

                string verificationCodeString = verificationCode.ToString();

                var verification = new Verification();

                verification.PhoneNumber = loginDto.PhoneNumber;
                verification.VerificationCode = verificationCodeString;
                verification.ExpirationTime = DateTime.Now.AddMinutes(3);

                await verificationService.AddAsync(verification);

                return CreateActionResult<LoginDto>(CustomResponseDto<LoginDto>.Success(200));

            }

            // Generate JWT token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("jXn2r5u8x/A?D(G+KaPdSgVkYp3s6v9y"); // Replace with your own secret key
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, loginDto.PhoneNumber),
            new Claim("Id", loginDto.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            loginDto.Token = tokenString;

            var loginReq = await loginService.AddAsync(imapper.Map<Login>(loginDto));

            var loginResponseDto = imapper.Map<LoginDto>(loginReq);

            return CreateActionResult<LoginDto>(CustomResponseDto<LoginDto>.Success(200, loginResponseDto));

        }


    }
}

