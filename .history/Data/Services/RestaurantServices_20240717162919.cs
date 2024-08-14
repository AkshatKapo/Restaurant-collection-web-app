using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Collection.Data.Models;

namespace Restaurant_Collection.Data.Services
{
    public class RestaurantServices : IRestaurantService
    {

        private readonly string connection_string;
        public RestaurantServices(IConfiguration configuration){
             // Retrieve the connection string from the configuration
    connectionString = configuration.GetConnectionString("MySqlConnection") 
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
            throw new NotImplementedException();
        }
    }
}