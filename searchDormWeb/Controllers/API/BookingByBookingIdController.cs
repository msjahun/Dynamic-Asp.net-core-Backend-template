﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

namespace searchDormWeb.Controllers.API
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingByBookingIdController : ControllerBase
    {
       

        // GET: api/BookingByBookingId/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            string Json = @"{
      ""Response"": ""Success"",
      ""Body"": {
                ""DormitoryId"": ""23"",
        ""BookingDate"": ""12 / 2 / 2018"",
        ""BookingStatus"": ""Confirmed"",
        ""paymentConfirmationExpiryDate"": ""23 / 4 / 2019"",
        ""BookingNo"": ""34343434"",
        ""RoomBooked"": ""Alfam single room"",
        ""DormitoryName"": ""Alfam dormitories""
      }

        }";

            JsonResult result = new JsonResult(JsonConvert.DeserializeObject(Json));

            return result;
          
        }

  
    }
}