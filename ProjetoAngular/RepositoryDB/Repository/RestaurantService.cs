using Microsoft.EntityFrameworkCore;
using ProjetoAngular.Database;
using ProjetoAngular.Models;
using ProjetoAngular.RepositoryDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAngular.RepositoryDB.Repository
{
    public class RestaurantService : IRestaurantService
    {
        private readonly AngularContext _angularContext;

        public RestaurantService(AngularContext angularContext)
        {
            _angularContext = angularContext;
        }

        public async Task<Restaurant> GetRestaurant(string id)
        {
            return await _angularContext.Restaurants.FirstOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        }

        public async Task<List<Restaurant>> GetRestaurants()
        {
            return await _angularContext.Restaurants.ToListAsync();
        }

        public async Task<List<Review>> GetReviews(string id)
        {
            return await _angularContext.Reviews.Where(x => x.RestaurantId == Convert.ToInt32(id)).ToListAsync();
        }
    }
}
