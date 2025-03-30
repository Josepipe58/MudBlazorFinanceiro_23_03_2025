using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class DespesaRepository(AppDbContext context) : Repository<Despesa>(context), IDespesaRepository
    {
        public async Task<IEnumerable<Despesa>> ObterDespesaAsync()
        {
            //_context é herança do Repository.
            return await _context.TDespesas.OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
