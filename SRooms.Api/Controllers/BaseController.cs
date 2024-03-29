﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRooms.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SRooms.Api.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {

        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {

            if (response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }


            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
        
    }
}

