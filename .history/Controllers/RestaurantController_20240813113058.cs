using System; // Import the system namespace for basic types and base classes
using System.Collections.Generic; // Import the namespace for generic collection types
using System.Linq; // Import the namespace for LINQ (Language-Integrated Query) operations
using System.Threading.Tasks; // Import the namespace for working with asynchronous operations
using Microsoft.AspNetCore.Mvc; 
using Restaurant_Collection.Data; 
using Restaurant_Collection.Data.Models; 
namespace Restaurant_Collection.Controllers
{
    // Indicates that this class is an API controller that will handle HTTP requests
    [ApiController]
    // Defines the route for this controller, where [controller] will be replaced by the controller name ("Restaurant")
    [Route("api/[controller]")]
    public class RestaurantController : Controller
    {
        // Private field to hold the restaurant service, which is injected via the constructor
        private readonly IRestaurantService _service;

        // Constructor to initialize the controller with the restaurant service
        public RestaurantController(IRestaurantService service)
        {
            _service = service; // Store the injected service in the private field
        }

        // Test endpoint to check if the controller is working
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Test endpoint works"); // Returns a 200 OK response with a test message
        }

        // Endpoint to retrieve all restaurants
        [HttpGet("[action]")]
        public IActionResult GetRestaurants()
        {
            var allRestaurants = _service.GetAllRestaurants(); // Get all restaurants from the service
            return Ok(allRestaurants); // Return a 200 OK response with the list of restaurants
        }

        // Endpoint to add a new restaurant
        [HttpPost("AddRestaurant")]
        public IActionResult AddRestaurant([FromBody] Restaurant rest)
        {
            _service.AddRestaurant(rest); // Add the new restaurant using the service
            return Ok(); // Return a 200 OK response indicating success
        }

        // Endpoint to delete a restaurant by its ID
        [HttpDelete("DeleteRestaurant/{Id}")]
        public IActionResult DeleteRestaurant(int id)
        {
            _service.DeleteRestaurant(id); // Delete the restaurant using the service
            return Ok(); // Return a 200 OK response indicating success
        }

        // Endpoint to retrieve a restaurant by its ID
        [HttpGet("GetRestaurantById/{Id}")]
        public IActionResult GetRestaurantById(int id)
        {
            var restaurant_ID = _service.GetRestaurantById(id); // Get the restaurant by ID using the service
            return Ok(restaurant_ID); // Return a 200 OK response with the restaurant data
        }
    }
}
