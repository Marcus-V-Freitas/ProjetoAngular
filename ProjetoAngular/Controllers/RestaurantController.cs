using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAngular.Models;
using ProjetoAngular.RepositoryDB.Interfaces;

namespace ProjetoAngular.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        [HttpGet("")]
        public async Task<IActionResult> TodosResultados()
        {
            try
            {
                return Ok(await _restaurantService.GetRestaurants());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterId([FromRoute] string id)
        {
            try
            {
                return Ok(await _restaurantService.GetRestaurant(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/Reviews")]
        public async Task<IActionResult> ObterReviewId([FromRoute] string id)
        {
            try
            {
                return Ok(await _restaurantService.GetReviews(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
