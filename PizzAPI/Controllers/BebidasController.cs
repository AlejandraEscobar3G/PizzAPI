using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzAPI.Dtos;
using PizzAPI.interfaces;
using PizzAPI.Services;

namespace PizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidasController : ControllerBase
    {
        private readonly IBebidasService _bebidasService;
        public BebidasController(IBebidasService bebidasService)
        {
            _bebidasService = bebidasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<BebidaDto> bebidas = _bebidasService.ObtenerBebidas();

            return Ok(bebidas);
        }
    }
}
