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
        //Returns a list of all restaurants.
        List<Restaurant> GetAllRestaurants();
        Returns a list of all restaurants.
        Restaurant GetRestaurantById(int id);
        void AddRestaurant(Restaurant newrestaurant);
        void DeleteRestaurant(int id);
        
    }
}