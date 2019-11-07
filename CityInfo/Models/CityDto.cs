using System.Collections.Generic;

namespace CityInfo.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest { get
            {
                return PointsOfInterest.Count;
            }   
        }

        public  ICollection<PointOfInterestDto> PointsOfInterest { get; set; } // initializing to null to eliminate nullreferenceexceptions
        = new List<PointOfInterestDto>();
    }
}