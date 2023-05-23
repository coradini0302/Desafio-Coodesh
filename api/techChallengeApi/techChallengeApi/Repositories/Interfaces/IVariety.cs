using techChallengeApi.Model;

namespace techChallengeApi.Repositories.Interfaces
{
    public interface IVariety
    {
        Task<List<Variety>> GetAllVariety();
        Task<Variety> GetVarietyById(int id);
        Task<Variety> AddVariety(Variety variety);
        Task<Variety> UpdateVariety(Variety variety, int id);
        Task<bool> DeleteVariety(int id);

    }
}
