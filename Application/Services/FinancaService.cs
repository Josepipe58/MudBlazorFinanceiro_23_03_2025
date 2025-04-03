using Application.Abstractions;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class FinancaService : IFinancaService
    {
        public IFinancaRepository _financaRepository;

        public FinancaService(IFinancaRepository financaRepository)
        {
            _financaRepository = financaRepository;
        }

        public async Task AdicionarFinanca(Financa financa)
        {
            await _financaRepository.AdicionarAsync(financa);
        }

        public async Task EditarFinanca(Financa financa)
        {
            await _financaRepository.EditarAsync(financa);
        }

        public async Task ExcluirFinanca(int id)
        {
            await _financaRepository.ExcluirAsync(id);
        }

        public async Task<Financa> ObterFinancaPorId(int id)
        {
            var financa = await _financaRepository.ObterPorIdAsync(id);
            return financa!;
        }

        public async Task<IEnumerable<Financa>> ObterListaDeFinancasPorAno(int ano)
        {
            return await _financaRepository.ObterFinancaPorAnoAsync(ano);
        }
    }
}
