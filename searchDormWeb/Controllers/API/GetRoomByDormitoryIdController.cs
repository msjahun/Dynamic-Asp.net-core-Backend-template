﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace searchDormWeb.Controllers.API
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GetRoomByDormitoryIdController : Controller
    {

        // GET: api/GetRoomByDormitoryId/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {



            var Response = new
            {
                Response = "Success",
                Body = new
                {

                    Rooms = new List<RoomGetByDormitoryIdVM>
                    {
                        new RoomGetByDormitoryIdVM
                        {
            pictureUrl="https://dormitories.emu.edu.tr/PublishingImages/Dormitories/alfam/6.jpg",
            dormitoryName="Alfam Dormitories",
            bedType="Normal bed",
            roomSize=58,
            roomQuotaRemaining=4,
            RoomPrice=1990,
            RoomId=12,
           DormitoryId=23
                        },
                        

                        new RoomGetByDormitoryIdVM
                        {
            pictureUrl="https://dormitories.emu.edu.tr/PublishingImages/Dormitories/alfam/6.jpg",
            dormitoryName="Alfam Dormitories",
            bedType="Normal bed",
            roomSize=58,
            roomQuotaRemaining=4,
            RoomPrice=1990,
            RoomId=12,
           DormitoryId=23
                        },


                        new RoomGetByDormitoryIdVM
                        {
            pictureUrl="https://dormitories.emu.edu.tr/PublishingImages/Dormitories/alfam/6.jpg",
            dormitoryName="Alfam Dormitories",
            bedType="Normal bed",
            roomSize=58,
            roomQuotaRemaining=4,
            RoomPrice=1990,
            RoomId=12,
           DormitoryId=23
                        }
                    }
                }

            };

        

            return Json(Response);
          
        }

        
        public class RoomGetByDormitoryIdVM
        {
            
                   public string pictureUrl {get; set;}
                   public string dormitoryName {get; set;}
                   public string bedType {get; set;}
                   public int roomSize {get; set;}
                   public int roomQuotaRemaining {get; set;}
                   public double RoomPrice {get; set;}
                   public long RoomId {get; set;}
                   public long DormitoryId {get; set;}
        }
    }
}
