using Domain.EntitiesLists;

namespace Application.Abstractions.RelatoriosAbstractions
{
    public interface IRelatorioDespesaService
    {
        SomarValoresDeDespesa RelatorioDeDespesasGeraisService(int ano);
    }
}
