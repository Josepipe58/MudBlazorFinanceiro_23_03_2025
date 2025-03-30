using Domain.Interfaces.RelatorioInterface;

namespace Application.Abstractions.RelatoriosAbstractions
{
    public interface IRelatorioDespesaService
    {
        ListaDeMeses RelatorioDeDespesasGeraisService(int ano);
    }
}
