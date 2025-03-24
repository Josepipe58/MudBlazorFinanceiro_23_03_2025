using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FinancaRepository(AppDbContext context) : Repository<Financa>(context), IFinancaRepository
    {
        public async Task<IEnumerable<Financa>> ObterFinancaAsync()
        {
            //_context é herança do Repository.
            return await _context.TFinancas.OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
