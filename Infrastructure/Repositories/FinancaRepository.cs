using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FinancaRepository(AppDbContext context) : Repository<Financa>(context), IFinancaRepository
    {
        public async Task<IEnumerable<Financa>> ObterFinancaPorAnoAsync(int ano)
        {
            //_context é herança do Repository.
            var listaDeFinancas = await _context.TFinancas.Select(x => new Financa()
            {
                Id = x.Id,
                NomeFinanca = x.NomeFinanca,
                NomeOperacao = x.NomeOperacao,
                Descricao = x.Descricao,
                Valor = x.Valor,
                Tipo = x.Tipo,
                Data = x.Data,
            }).Where(x => x.Data.Value.Year == ano).OrderByDescending(x => x.Id).ToListAsync();

            return [.. listaDeFinancas];
        }
    }
}
