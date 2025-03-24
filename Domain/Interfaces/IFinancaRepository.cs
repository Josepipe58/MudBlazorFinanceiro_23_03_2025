using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IFinancaRepository : IRepository<Financa>
    {
        //Esse método foi criada para obter um OrderByDescending individual.
        Task<IEnumerable<Financa>> ObterFinancaAsync();
    }
}
