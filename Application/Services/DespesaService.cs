using Application.Abstractions;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class DespesaService : IDespesaService
    {
        public IDespesaRepository _despesaRepository;

        public DespesaService(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public async Task AdicionarDespesa(Despesa despesa)
        {
            await _despesaRepository.AdicionarAsync(despesa);
        }

        public async Task EditarDespesa(Despesa despesa)
        {
            await _despesaRepository.EditarAsync(despesa);
        }

        public async Task ExcluirDespesa(int id)
        {
            await _despesaRepository.ExcluirAsync(id);
        }

        public async Task<Despesa> ObterDespesaPorId(int id)
        {
            var despesa = await _despesaRepository.ObterPorIdAsync(id);
            return despesa!;
        }

        public async Task<IEnumerable<Despesa>> ObterListaDeDespesasPorAno(int ano)
        {
            return await _despesaRepository.ObterDespesaPorAnoAsync(ano);
        }
    }
}
