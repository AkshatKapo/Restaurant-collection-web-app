using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Collection.Data;

namespace Restaurant_Collection.Data
{
    public interface IRestaurantService
    {
        List<Restaurant> GetRestaurants();
        
    }
}