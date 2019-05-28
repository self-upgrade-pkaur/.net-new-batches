using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantClient.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Rating { get; set; }
        public Location location { get; set; }
        static List<Restaurant> restaurants = new List<Restaurant>(){
        new Restaurant()
        {
            Id = 1,
            Name = "Chipotle",
            Rating = 4.5,
            location = new Location() { id = 1, RestaurantId = 1, Add1 = "11730 Plaza America", Add2 = "#205", City = "Reston", State = "VA", Country = "US", ZipCode = "20190" }
        },
        new Restaurant()
        {
            Id = 2,
            Name = "Mod's",
            Rating = 4.2,
            location = new Location() { id = 2, RestaurantId = 2, Add1 = "11730 Plaza America", Add2 = "#205", City = "Reston", State = "VA", Country = "US", ZipCode = "20190" }
        }
        };
        
        public static IEnumerable<Restaurant> GetRestaurants()
        {            
            return restaurants;
        }
        public static Restaurant GetRestaurantsById(int id)
        {
            return restaurants.Where(x => x.Id == id).FirstOrDefault() ;
        }
    }
   

}
