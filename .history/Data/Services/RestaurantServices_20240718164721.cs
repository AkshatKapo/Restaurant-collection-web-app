using MySql.Data.MySqlClient;
using Restaurant_Collection.Data.Models;

namespace Restaurant_Collection.Data.Services
{
    public class RestaurantServices : IRestaurantService
    {

        private readonly string connection_string;
        public RestaurantServices(IConfiguration configuration)
        {
            // Retrieve the connection string from the configuration
            connection_string = configuration.GetConnectionString("MySqlConnection")
                               // If the connection string is not found, throw an exception
                               ?? throw new InvalidOperationException("Connection string 'MySqlConnection' not found.");
        }

        public void AddRestaurant(Restaurant newrestaurant)
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>();
            using (var connection = new MySqlConnection(connection_string)) {
                connection.Open();
                string query = "SELECT * FROM  "

                
            }
        }
    }
}