using System.Linq;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            // Return 404 not found when the city id passed in doesnt exist. Cant have a point of interest in a city when the city(parent) is null.
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city.PointsOfInterest);
        }
        
        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            //var pointOfInterest = PointOfInterestDto.Cuu
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == id);

            if (pointOfInterest == null)
                return NotFound();

            return Ok(pointOfInterest);
        }
    }
}