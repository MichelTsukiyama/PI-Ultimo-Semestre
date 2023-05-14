using back.Model.Sponsor;

namespace back.Interface
{
    public interface IParceiroRepository
    {
        Parceiro GetParceiroById(int id);
        List<Parceiro> GetAllParceiros();
        Parceiro CreateParceiro(Parceiro parceiro);
        Parceiro UpdateParceiro(Parceiro parceiro);
        void DeleteParceiro(int id);
    }
}