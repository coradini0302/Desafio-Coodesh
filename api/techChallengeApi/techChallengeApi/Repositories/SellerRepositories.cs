using Microsoft.EntityFrameworkCore;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApi.Repositories
{
    public class SellerRepositories : ISeller
    {
        private readonly ApplicationDbContext _context;

        public SellerRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Seller> AddSeller(Seller seller)
        {
            _context.Seller.Add(seller);
            await _context.SaveChangesAsync();
            return seller;
        }

        public async Task<bool> DeleteSeller(int id)
        {
            Seller sellerById = await GetSellerById(id);

            if (sellerById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            _context.Seller.Remove(sellerById);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Seller>> GetAllSellers()
        {
             List<Seller> sellerList = await _context.Seller.ToListAsync();
            if (sellerList == null)
            {
                throw new Exception($"Tipo não foi encontrado  no banco de dados.");

            }
            return sellerList;
        }

        public async Task<Seller> GetSellerById(int id)
        {
            Seller sellerById = await _context.Seller.FirstOrDefaultAsync(x => x.Id == id);
            if (sellerById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");

            }

            return sellerById;
        }

        public async Task<Seller> UpdateSeller(Seller seller, int id)
        {
            Seller sellerById = await GetSellerById(id);

            if (sellerById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            sellerById.Name = seller.Name;

            await _context.Seller.AddAsync(sellerById);
            await _context.SaveChangesAsync();



            return sellerById;
        }
    }
}
