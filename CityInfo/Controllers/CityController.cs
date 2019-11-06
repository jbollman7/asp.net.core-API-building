using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    //you can change out cities with [controller]. this will allow it to be more dynamic.
    [Route("api/cities")]
    public class CityController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));

        }

    } //class
} //namespace
