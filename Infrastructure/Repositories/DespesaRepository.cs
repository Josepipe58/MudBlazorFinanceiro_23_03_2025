using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class DespesaRepository(AppDbContext context) : Repository<Despesa>(context), IDespesaRepository
    {
        public async Task<IEnumerable<Despesa>> ObterDespesaPorAnoAsync(int ano)
        {
            //_context é herança do Repository.
            var listaDeDespesas = await _context.TDespesas.Select(x => new Despesa()
            {
                Id = x.Id,
                NomeCategoria = x.NomeCategoria,
                Descricao = x.Descricao,
                Valor = x.Valor,
                Tipo = x.Tipo,
                Data = x.Data,
            }).Where(x => x.Data.Value.Year == ano).OrderByDescending(x => x.Id).ToListAsync();

            return [.. listaDeDespesas];
        }
    }
}
