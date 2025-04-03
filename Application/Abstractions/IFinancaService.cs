using Domain.Entities;

namespace Application.Abstractions
{
    public interface IFinancaService
    {
        Task<IEnumerable<Financa>> ObterListaDeFinancasPorAno(int ano);
        Task<Financa> ObterFinancaPorId(int id);
        Task AdicionarFinanca(Financa financa);
        Task EditarFinanca(Financa financa);
        Task ExcluirFinanca(int id);
    }
}
