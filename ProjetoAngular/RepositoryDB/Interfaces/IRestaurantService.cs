using ProjetoAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAngular.RepositoryDB.Interfaces
{
    public interface IRestaurantService
    {
        Task<List<Restaurant>> GetRestaurants();

        Task<Restaurant> GetRestaurant(string id);

        Task<List<Review>> GetReviews(string id);
    }
}
