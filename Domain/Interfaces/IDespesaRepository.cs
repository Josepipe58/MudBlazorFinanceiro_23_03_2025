using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDespesaRepository : IRepository<Despesa>
    {
        //Esse método foi criada para obter um OrderByDescending individual.
        Task<IEnumerable<Despesa>> ObterDespesaAsync();
    }
}
