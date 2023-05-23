using Microsoft.EntityFrameworkCore;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApi.Repositories
{
    public class ProductsRepositories : IProducts
    {
        private readonly ApplicationDbContext _context;

        public ProductsRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Products> AddProducts(Products products)
        {
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
            return products;
        }

        public async Task<bool> DeleteProducts(int id)
        {
            Products productsById = await GetProductsById(id);

            if (productsById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            _context.Products.Remove(productsById);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            List<Products> productsList = await _context.Products.ToListAsync();
            if (productsList == null)
            {
                throw new Exception($"Tipo não foi encontrado  no banco de dados.");

            }
            return productsList; 
        }

        public async Task<Products> GetProductsById(int id)
        {
            Products productsById = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (productsById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");

            }

            return productsById;
        }

        public async Task<Products> UpdateProducts(Products products, int id)
        {

            Products productsById = await GetProductsById(id);

            if (productsById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            productsById.Name = products.Name;

            await _context.Products.AddAsync(productsById);
            await _context.SaveChangesAsync();



            return productsById;
        }
    }
}
