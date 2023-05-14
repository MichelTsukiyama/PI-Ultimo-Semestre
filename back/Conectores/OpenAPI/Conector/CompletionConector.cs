using System.Net.Http.Headers;
using System.Text;
using back.Conectores.OpenAPI.Interface;
using back.Model.OpenAPI;
using Newtonsoft.Json;

namespace back.Conectores.OpenAPI.Conector
{
    public class CompletionConector : ICompletionConector
    {
        private readonly IConfiguration Configuration;

        public CompletionConector(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<CompletionResponse> PostCompletion(CompletionRequest request)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Configuration.GetValue<string>("OpenAI_Api_Key"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var jsonContent = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(Configuration.GetValue<string>("CompletionsUrl"), httpContent);

            var responseContent = JsonConvert.DeserializeObject<CompletionResponse>(await response.Content.ReadAsStringAsync());

            return responseContent;
        }
    }
}