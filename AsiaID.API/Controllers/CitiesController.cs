using AsiaID.API.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsiaID.API.Controllers
{
    //Controller attribute: not necessary but configure this controller with features that improve a developing experience when building API.
    //for example: requiring certain types of routing, automatically returning 400 bad requests, returning problem details while errors
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase //Base
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            var temp = CitiesDataStore.Current.Cities;
           return Ok(temp);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities
                    .FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null) {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
