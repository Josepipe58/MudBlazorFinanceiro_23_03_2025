using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDespesaRepository : IRepository<Despesa>
    {     
        Task<IEnumerable<Despesa>> ObterDespesaPorAnoAsync(int ano);
    }
}
