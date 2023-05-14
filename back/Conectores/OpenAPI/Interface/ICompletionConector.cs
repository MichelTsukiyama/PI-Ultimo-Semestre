using back.Model.OpenAPI;

namespace back.Conectores.OpenAPI.Interface
{
    public interface ICompletionConector
    {
        Task<CompletionResponse> PostCompletion(CompletionRequest request);
    }
}