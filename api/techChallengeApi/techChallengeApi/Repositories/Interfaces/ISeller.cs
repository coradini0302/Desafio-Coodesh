using techChallengeApi.Model;

namespace techChallengeApi.Repositories.Interfaces
{
    public interface ISeller
    {
        Task<List<Seller>> GetAllSellers();
        Task<Seller> AddSeller(Seller seller);
        Task<Seller> GetSellerById(int id);
        Task<Seller> UpdateSeller(Seller seller, int id);
        Task<bool> DeleteSeller(int id);

    }
}
