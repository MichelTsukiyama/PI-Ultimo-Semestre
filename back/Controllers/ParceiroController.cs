using back.Interface;
using back.Model.Sponsor;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParceiroController : ControllerBase
    {
        private readonly IParceiroRepository _parceiroRepository;

        public ParceiroController(IParceiroRepository parceiroRepository)
        {
            _parceiroRepository = parceiroRepository;
        }

        [HttpGet("/Parceiros/{id}")]
        public ActionResult<Parceiro> GetParceiroById(int id)
        {
            return _parceiroRepository.GetParceiroById(id);
        }

        [HttpGet("/Parceiros")]
        public ActionResult<List<Parceiro>> GetAllParceiros()
        {
            return _parceiroRepository.GetAllParceiros();
        }

        [HttpPost("/Parceiros")]
        public ActionResult<Parceiro> PostParceiro(Parceiro parceiro)
        {
            return _parceiroRepository.CreateParceiro(parceiro);
        }

        [HttpPut("/Parceiros")]
        public ActionResult<Parceiro> PutParceiro(Parceiro parceiro)
        {
            return _parceiroRepository.UpdateParceiro(parceiro);
        }

        [HttpDelete("/Parceiros/{id}")]
        public ActionResult DeleteParceiro(int id)
        {
            _parceiroRepository.DeleteParceiro(id);
            return Ok();
        }
    }
}