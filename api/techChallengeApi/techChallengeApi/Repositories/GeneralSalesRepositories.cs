using Microsoft.EntityFrameworkCore;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApi.Repositories
{
    public class GeneralSalesRepositories : IGeneralSales
    {
        private readonly ApplicationDbContext _context;

        public GeneralSalesRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GeneralSales> AddGeneralSales(GeneralSales generalSales)
        {
            await _context.GeneralSales.AddAsync(generalSales);
            await _context.SaveChangesAsync();
            return generalSales;
        }

        public async Task<bool> DeleteGeneralSales(int id)
        {
            GeneralSales generalSalesById = await GetGeneralSalesById(id);

            if (generalSalesById != null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            _context.GeneralSales.Remove(generalSalesById);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<GeneralSales>> GetAllProducts()
        {
            List<GeneralSales> generalSalesList = await _context.GeneralSales.Include(g => g.Variety).Include(g => g.Product).Include(g =>g.Seller).ToListAsync();
            if (generalSalesList == null)
            {
                throw new Exception($"Tipo não foi encontrado  no banco de dados.");

            }

            
            return generalSalesList;
        }

        public async Task<GeneralSales> GetGeneralSalesById(int id)
        {
            GeneralSales generalSalesById = await _context.GeneralSales.FirstOrDefaultAsync(x => x.Id == id);
            if (generalSalesById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");

            }

            return generalSalesById;
        }

        public async Task<GeneralSales> UpdateGeneralSales(GeneralSales generalSales, int id)
        {
            GeneralSales generalSalesById = await GetGeneralSalesById(id);

            if (generalSales == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            generalSalesById.Seller = generalSales.Seller;
            generalSalesById.Value = generalSales.Value;
            generalSalesById.Product = generalSales.Product;
            generalSalesById.Date = generalSales.Date;
            generalSalesById.Variety = generalSales.Variety;

            await _context.GeneralSales.AddAsync(generalSalesById);
            await _context.SaveChangesAsync();



            return generalSales; 
        }
    }
}
