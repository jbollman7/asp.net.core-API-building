using System.Collections.Generic;
using CityInfo.Models;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get;  } = new CitiesDataStore();   //auto property initialiation syntax. assignment of properties directly in their decleration.
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New york City",
                    Description = "The one with Central Park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "super duper popular"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "King of buildings"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The city with the cathedral that was never finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Old Cathedral never finished",
                            Description = "In Capitol"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Waffles",
                            Description = " Belgium Waffles."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Home of eifel tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Eifel Tower Park",
                            Description = "Take Pictures here."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Arch of Triumph",
                            Description = "Built in 19th century when France was relevant."
                        },
                    }
                }
            };
        }

    }
}