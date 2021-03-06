﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using searchDormWeb.Models;
using Dau.Services.Utilities;
using Dau.Core.Domain;

namespace searchDormWeb.Controllers.API
{
    [Produces("application/json")]
   
    [ApiController]
    public class CreateBookingController : Controller
    {
        private readonly IApiLogService _apiLogService;

        public CreateBookingController(IApiLogService apiLogService)
        {
            _apiLogService = apiLogService;
        }


       


        [Route("api/[controller]")]
        // POST: api/CreateBooking
        [HttpPost]
        public JsonResult Post()
        {
            ResponseResult response = new ResponseResult
            {
                Response = true,
                StatusCode = "0x3234"
            };


            _apiLogService.LogApiRequest(new ApiDebugLog
            {

                ApiName = " // POST: api/CreateBooking",
                Reponse = JsonConvert.SerializeObject(response),
                CreateDateTime = DateTime.Now,
                ParameterRecieved = JsonConvert.SerializeObject(_apiLogService.GetRequestBody())
            });
            return Json(response);
        }



    }
}
