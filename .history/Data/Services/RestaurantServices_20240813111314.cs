using MySql.Data.MySqlClient; 
using Restaurant_Collection.Data.Models; 

namespace Restaurant_Collection.Data.Services
{
   
    public class RestaurantServices : IRestaurantService
    {
        // Private field to store the database connection string
        private readonly string connection_string;

        // Constructor to initialize the service with the configuration settings
        public RestaurantServices(IConfiguration configuration)
        {
            // Retrieve the connection string from the configuration
            connection_string = configuration.GetConnectionString("MySqlConnection")
                               // If the connection string is not found, throw an exception
                               ?? throw new InvalidOperationException("Connection string 'MySqlConnection' not found.");
        }

        // Method to add a new restaurant to the database
        public void AddRestaurant(Restaurant newrestaurant)
        {
            // Establish a connection to the MySQL database
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open(); // Open the connection

                // SQL query to insert a new restaurant record
                string query = "INSERT INTO restaurants (Name, Location, Food, Rate) " +
                               "VALUES (@Name, @Location, @Food, @Rate)";
                
                // Create a command to execute the query
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Name", newrestaurant.Restaurant_Name);
                    command.Parameters.AddWithValue("@Location", newrestaurant.Location);
                    command.Parameters.AddWithValue("@Food", newrestaurant.Food);
                    command.Parameters.AddWithValue("@Rate", newrestaurant.Rate);

                    command.ExecuteNonQuery(); // Execute the query to insert the record
                }
            }
        }

        // Method to delete a restaurant from the database by its ID
        public void DeleteRestaurant(int id)
        {
            // Establish a connection to the MySQL database
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open(); // Open the connection

                // SQL query to delete a restaurant record by its ID
                string query = "DELETE FROM restaurants WHERE Id=@Id";
                
                // Create a command to execute the query
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add the ID parameter to the query
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery(); // Execute the query to delete the record
                }
            }
        }

        // Method to retrieve a restaurant from the database by its ID
        public Restaurant GetRestaurantById(int id)
        {
            Restaurant new_restaurant = null; // Initialize a variable to store the restaurant data

            // Establish a connection to the MySQL database
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open(); // Open the connection

                // SQL query to select a restaurant record by its ID
                string query = "SELECT * FROM restaurants WHERE Id=@id";
                
                // Create a command to execute the query
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add the ID parameter to the query
                    command.Parameters.AddWithValue("@id", id);

                    // Execute the query and retrieve the data using a data reader
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Read the first row from the result set
                        {
                            // Map the data from the reader to the Restaurant object
                            new_restaurant = new Restaurant
                            {
                                Id = reader.GetInt32("Id"),
                                Restaurant_Name = reader.GetString("Name"),
                                Location = reader.GetString("Location"),
                                Rate = reader.GetDouble("Rate")
                                // Map other columns as needed
                            };
                        }
                    }
                }
            }

            return new_restaurant; // Return the retrieved restaurant data
        }

        // Method to retrieve a list of all restaurants from the database
        public List<Restaurant> GetAllRestaurants()
        {
            var restaurants = new List<Restaurant>(); // Initialize a list to store the restaurants

            // Establish a connection to the MySQL database
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open(); // Open the connection

                // SQL query to select all restaurant records, ordered by rating in descending order
                string query = "SELECT * FROM restaurants ORDER BY rate DESC";
                
                // Create a command to execute the query
                using var command = new MySqlCommand(query, connection);
                
                // Execute the query and retrieve the data using a data reader
                using var reader = command.ExecuteReader();

                while (reader.Read()) // Loop through all rows in the result set
                {
                    // Map the data from the reader to the Restaurant object
                    var restuar = new Restaurant
                    {
                        Id = reader.GetInt32("id"),
                        Restaurant_Name = reader.GetString("Name"),
                        Location = reader.GetString("Location"),
                        Food = reader.GetString("Food"),
                        Rate = reader.GetDouble("Rate")
                    };

                    // Add the restaurant to the list
                    restaurants.Add(restuar);
                }
            }

            return restaurants; // Return the list of all restaurants
        }
    }
}
