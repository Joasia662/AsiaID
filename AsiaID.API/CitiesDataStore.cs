using AsiaID.API.Models;

namespace AsiaID.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //singleton pattern at work
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() {

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Cracow",
                    Description = "Dragon lived here"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Warsaw",
                    Description = "This is the capital"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Poznan",
                    Description = "Rogale yummy yummy"
                }

            };
        }
    }
}
