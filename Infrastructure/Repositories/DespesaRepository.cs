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
            var listaDeDespesas = await _context.TDespesas.Select(d => new Despesa()
            {
                Id = d.Id,
                NomeCategoria = d.NomeCategoria,
                Descricao = d.Descricao,
                Valor = d.Valor,
                Tipo = d.Tipo,
                Data = d.Data,
            }).Where(x => x.Data.Value.Year == ano).OrderByDescending(x => x.Id).ToListAsync();

            return [.. listaDeDespesas];
        }
    }
}
