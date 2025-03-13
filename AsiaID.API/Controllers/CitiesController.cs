using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsiaID.API.Controllers
{
    //Controller attribute: not necessary but configure this controller with features that improve a developing experience when building API.
    //for example: requiring certain types of routing, automatically returning 400 bad requests, returning problem details while errors
    [ApiController] 
    public class CitiesController : ControllerBase //Base
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
           return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
            );
        }
    }
}
