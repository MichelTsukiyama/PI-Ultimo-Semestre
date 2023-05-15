using back.Conectores.OpenAPI.Interface;
using back.Interface;
using back.Model.OpenAPI;
using back.Model.OpenAPI.Rules;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompletionController : ControllerBase
    {
        public readonly ICompletionConector _completionConector;
        private readonly IOpenApiRulesRepository _openApiRulesRepository;
        private readonly IParceiroRepository _parceiroRepository;

        public CompletionController(ICompletionConector completionConector, IOpenApiRulesRepository openApiRulesRepository, IParceiroRepository parceiroRepository)
        {
            _completionConector = completionConector;
            _openApiRulesRepository = openApiRulesRepository;
            _parceiroRepository = parceiroRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Message>> GetCompletionAsync(string content)
        {
            Random random = new Random();
            int valorAleatorio = random.Next(1, 3);
            var regras = _openApiRulesRepository.GetAllRules();
            var parceiro = _parceiroRepository.GetAllParceiros().FirstOrDefault(x => x.Id == valorAleatorio);

            string gptRequest = "";

            foreach (var regra in regras)
            {
                if(regra.Regra.Contains("SPONSOR"))
                    regra.Regra = regra.Regra.Replace("SPONSOR", parceiro.Nome);

                if(regra.Regra.Contains("URL"))
                    regra.Regra = regra.Regra.Replace("URL", parceiro.Dominio);

                gptRequest += regra.Regra;
            }

            gptRequest += content;

            var request = new CompletionRequest(gptRequest);
            var completionResponse = await _completionConector.PostCompletion(request);
            var response = completionResponse.Choices[0].Message;

            return Ok(response);
        }

        [HttpGet("/Rules/{id}")]
        public ActionResult<OpenApiRules> GetRuleById(int id)
        {
            return _openApiRulesRepository.GetRuleById(id);
        }

        [HttpGet("/Rules")]
        public ActionResult<List<OpenApiRules>> GetAllRules()
        {
            return _openApiRulesRepository.GetAllRules();
        }

        [HttpPost("/Rules")]
        public ActionResult<OpenApiRules> PostRules(OpenApiRules rules)
        {
            return _openApiRulesRepository.CreateRule(rules);
        }

        [HttpPut("/Rules")]
        public ActionResult<OpenApiRules> PutRules(OpenApiRules rules)
        {
            return _openApiRulesRepository.UpdateRule(rules);
        }

        [HttpDelete("/Rules/{id}")]
        public ActionResult DeleteRules(int id)
        {
            _openApiRulesRepository.DeleteRule(id);
            return Ok();
        }
    }
}