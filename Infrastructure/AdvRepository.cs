using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AdvRepository : IAdvRepository
    {
        private readonly StoreContext _context;

        public AdvRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Adv> GetAdvByIdAsync(int id)
        {
            return await _context.Advs
                .Include(a =>a.VnRetrofitType)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IReadOnlyList<Adv>> GetAdvsAsync()
        {
            return await _context.Advs
                .Include(a =>a.VnRetrofitType)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<VnRetrofitType>> GetAdvVnRetrofiTypesAsync()
        {
            return await _context.VnRetrofitTypes.ToListAsync();
        }
    }
}