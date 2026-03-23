using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzAPI.Dtos;
using PizzAPI.interfaces;
using PizzAPI.Services;

namespace PizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasasController : ControllerBase
    {
        private readonly IMasasService _masasService;
        public MasasController(IMasasService masasService)
        {
            _masasService = masasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<MasaDto> masas = _masasService.ObtenerMasas();

            return Ok(masas);
        }
    }
}
