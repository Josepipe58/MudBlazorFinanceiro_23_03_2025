using Domain.Entities;

namespace Application.Abstractions
{
    public interface IFinancaService
    {
        Task<IEnumerable<Financa>> ObterListaDeFinancas();
        Task<Financa> ObterFinancaPorId(int id);
        Task AdicionarFinanca(Financa financa);
        Task EditarFinanca(Financa financa);
        Task ExcluirFinanca(int id);
    }
}
