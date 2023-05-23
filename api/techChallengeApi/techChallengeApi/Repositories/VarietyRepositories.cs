using Microsoft.EntityFrameworkCore;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApi.Repositories
{
    public class VarietyRepositories : IVariety
    {
        private readonly ApplicationDbContext _context;

        public VarietyRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Variety> AddVariety(Variety variety)
        {

            await _context.Varieties.AddAsync(variety);
            await _context.SaveChangesAsync();
            return variety;
        }

        public async Task<bool> DeleteVariety(int id)
        {
            Variety varietyById = await GetVarietyById(id);

            if(varietyById != null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            _context.Varieties.Remove(varietyById);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Variety>> GetAllVariety()
        {
            List<Variety> varietyList = await _context.Varieties.ToListAsync();
            if(varietyList == null)
            {
                throw new Exception($"Tipo não foi encontrado  no banco de dados.");

            }
            return varietyList;
        }

        public async Task<Variety> GetVarietyById(int id)
        {
            Variety varietyById = await _context.Varieties.FirstOrDefaultAsync(x => x.Id == id);
            if(varietyById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");

            }

            return varietyById;
        }

        public async Task<Variety> UpdateVariety(Variety variety, int id)
        {
            Variety varietyById = await GetVarietyById(id);

            if(varietyById == null)
            {
                throw new Exception($"Tipo para o ID:{id} não  foi encontrado  no banco de dados.");
            }

            varietyById.Description = variety.Description;
            varietyById.Sort = variety.Sort;
            varietyById.Kind = variety.Kind;
            varietyById.Signal = variety.Signal;

            await _context.Varieties.AddAsync(varietyById);
            await _context.SaveChangesAsync();



            return varietyById;
        }
    }
}
