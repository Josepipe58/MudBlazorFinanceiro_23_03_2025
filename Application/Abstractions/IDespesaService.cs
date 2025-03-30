using Domain.Entities;

namespace Application.Abstractions
{
    public interface IDespesaService
    {
        Task<IEnumerable<Despesa>> ObterListaDeDespesasPorAno(int ano);
        Task<Despesa> ObterDespesaPorId(int id);
        Task AdicionarDespesa(Despesa despesa);
        Task EditarDespesa(Despesa despesa);
        Task ExcluirDespesa(int id);
    }
}
