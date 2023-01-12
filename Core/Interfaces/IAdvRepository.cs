using Core.Entities;

namespace Core.Interfaces
{
    public interface IAdvRepository
    {
        Task<Adv> GetAdvByIdAsync(int id);
        Task<IReadOnlyList<Adv>> GetAdvsAsync();
        Task<IReadOnlyList<VnRetrofitType>> GetAdvVnRetrofiTypesAsync();
        
    }
}