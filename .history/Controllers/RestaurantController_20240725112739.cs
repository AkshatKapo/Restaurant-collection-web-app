using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Collection.Data;

namespace Restaurant_Collection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }

        // Test endpoint
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Test endpoint works");
        }

        // Read all restaurants
        [HttpGet("[action]")]
        public IActionResult GetRestaurants()
        {
            var allRestaurants = _service.GetAllRestaurants();
            return Ok(allRestaurants);
        }
        [HttpPost("AddRestaurant")]

        public IActionResult AddRestaurant

    }
}
