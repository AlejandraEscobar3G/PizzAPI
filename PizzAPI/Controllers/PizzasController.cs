using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzAPI.Dtos;
using PizzAPI.interfaces;
using PizzAPI.Services;

namespace PizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly IPizzasService _pizzasService;
        public PizzasController(IPizzasService pizzasService)
        {
            _pizzasService = pizzasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ProductoDto> pizzas = _pizzasService.ObtenerPizzas();

            return Ok(pizzas);
        }
    }
}
