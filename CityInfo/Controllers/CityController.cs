using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    public class CityController : Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new { id=1, Name="New York City" },
                new { id=2, Name="Antwerp"}
            });
        }


    } //class
} //namespace
