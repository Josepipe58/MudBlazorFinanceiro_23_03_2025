using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IFinancaRepository : IRepository<Financa>
    {
        Task<IEnumerable<Financa>> ObterFinancaPorAnoAsync(int ano);
    }
}
