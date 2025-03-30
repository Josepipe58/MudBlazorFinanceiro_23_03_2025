using Domain.EntitiesLists;

namespace Domain.Interfaces.RelatorioInterface
{
    public interface IRelatorioDespesaRepository
    {
        SomarValoresDeDespesa RelatorioDeDespesasGerais(int ano);
    }
}
