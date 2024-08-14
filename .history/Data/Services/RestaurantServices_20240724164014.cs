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
            using (var connection = new MySqlConnection(connection_string))
            {

                connection.Open();
                string query = "INSERT INTO restaurants (Name, Location, Food, Rate) " +
                           "VALUES (@Name, @Location, @Food, @Rate)";
                 using (var command = new MySqlCommand(query,connection)){
                    command.Parameters.AddWithValue("@Name", newrestaurant.Restaurant_Name);
                    command.Parameters.AddWithValue("@Location", newrestaurant.Location);
                    command.Parameters.AddWithValue("@Fod")

                 }


            }

        }

        public void DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            var restaurants = new List<Restaurant>();
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                string query = "SELECT * FROM restaurants ";
                using var command = new MySqlCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var restuar = new Restaurant
                    {

                        Id = reader.GetInt32("id"),
                        Restaurant_Name = reader.GetString("Name"),
                        Location = reader.GetString("Location"),
                        Food = reader.GetString("Food"),
                        Rate = reader.GetDouble("Rate")
                    };

                    restaurants.Add(restuar);
                }
            }
            return restaurants;



        }
    }
}
