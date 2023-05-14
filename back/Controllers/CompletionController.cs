using back.Conectores.OpenAPI.Interface;
using back.Model.OpenAPI;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompletionController : ControllerBase
    {
        public readonly ICompletionConector _completionConector;

        public CompletionController(ICompletionConector completionConector)
        {
            _completionConector = completionConector;
        }

        [HttpGet]
        public async Task<ActionResult<Message>> GetCompletionAsync(string content)
        {
            var request = new CompletionRequest(content);
            var completionResponse = await _completionConector.PostCompletion(request);
            var response = completionResponse.Choices[0].Message;

            return Ok(response);
        }
    }
}