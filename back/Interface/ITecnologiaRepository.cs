using back.Model;

namespace back.Interface
{
    public interface ITecnologiaRepository
    {
         Tecnologia GetTecnologiaAsync(string? Nome);
    }
}