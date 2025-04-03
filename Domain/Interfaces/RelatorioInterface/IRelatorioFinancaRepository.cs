using Domain.EntitiesLists;

namespace Domain.Interfaces.RelatorioInterface
{
    public interface IRelatorioFinancaRepository
    {
        SomarValoresDeFinanca RelatorioSaldoTotalFinanca(int ano);
    }
}
