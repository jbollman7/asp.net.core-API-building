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
                    Description = "The one with Central Park"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The city with the cathedral that was never finished."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Home of eifel tower."
                }
            };
        }

    }
}