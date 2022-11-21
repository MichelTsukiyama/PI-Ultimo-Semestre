using back.Context;
using back.Interface;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TecnologiaController : ControllerBase
    {
        public readonly ITecnologiaRepository _tecnologiaRepository;

        public TecnologiaController(ITecnologiaRepository tecnologiaRepository)
        {
            _tecnologiaRepository = tecnologiaRepository;
        }

        [HttpGet("{nome}")]
        public IActionResult GetTecnologias(string nome){
            return Ok(_tecnologiaRepository.GetTecnologiaAsync(nome));
        }
    }
}