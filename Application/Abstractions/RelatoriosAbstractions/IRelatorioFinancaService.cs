using Domain.EntitiesLists;

namespace Application.Abstractions.RelatoriosAbstractions
{
    public interface IRelatorioFinancaService
    {
        SomarValoresDeFinanca RelatorioSaldoTotalFinancaService(int ano);
    }
}
