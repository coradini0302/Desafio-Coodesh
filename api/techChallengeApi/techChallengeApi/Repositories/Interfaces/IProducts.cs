using techChallengeApi.Model;

namespace techChallengeApi.Repositories.Interfaces
{
    public interface IProducts
    {
        Task<List<Products>> GetAllProducts();
        Task<Products> GetProductsById(int id);
        Task<Products> AddProducts(Products products);
        Task<Products> UpdateProducts(Products products, int id);
        Task<bool> DeleteProducts(int id);

    }
}
