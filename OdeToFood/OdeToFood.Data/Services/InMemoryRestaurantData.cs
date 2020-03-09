namespace OdeToFood.Data.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class InMemoryRestaurantData : IRestuarantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
              {
                new Restaurant{ Id = 1, Name = "Scotts Pizza", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 2, Name = "Tersigues", Cuisine = CuisineType.French },
                new Restaurant{ Id = 3, Name = "Mongo Grove", Cuisine = CuisineType.Indian },
              };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}