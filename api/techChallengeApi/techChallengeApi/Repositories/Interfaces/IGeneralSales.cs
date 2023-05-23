using techChallengeApi.Model;

namespace techChallengeApi.Repositories.Interfaces
{
    public interface IGeneralSales
    {
        Task<List<GeneralSales>> GetAllProducts();
        Task<GeneralSales> GetGeneralSalesById(int id);
        Task<GeneralSales> AddGeneralSales(GeneralSales generalSales);
        Task<GeneralSales> UpdateGeneralSales(GeneralSales generalSales, int id);
        Task<bool> DeleteGeneralSales(int id);

    }
}
