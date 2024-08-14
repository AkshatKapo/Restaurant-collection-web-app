using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Collection.Data;
using Restaurant_Collection.Data.Models;

namespace Restaurant_Collection.Data
{
    public interface IRestaurantService
    {
        // Method to retrieve a list of all restaurants.
        List<Restaurant> GetAllRestaurants();

        // Method to retrieve a single restaurant by its ID.
        Restaurant GetRestaurantById(int id);

        // Method to add a new restaurant.
        void AddRestaurant(Restaurant newrestaurant);

        // Method to delete a restaurant by its ID.
        void DeleteRestaurant(int id);
    }
}
