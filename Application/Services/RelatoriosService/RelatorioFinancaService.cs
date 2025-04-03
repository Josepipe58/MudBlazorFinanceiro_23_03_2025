using Application.Abstractions.RelatoriosAbstractions;
using Domain.EntitiesLists;
using Domain.Interfaces.RelatorioInterface;

namespace Application.Services.RelatoriosService
{
    public class RelatorioFinancaService : IRelatorioFinancaService
    {
        IRelatorioFinancaRepository _relatorioFinancaRepository;

        public RelatorioFinancaService(IRelatorioFinancaRepository relatorioFinancaRepository)
        {
            _relatorioFinancaRepository = relatorioFinancaRepository;
        }

        public SomarValoresDeFinanca RelatorioSaldoTotalFinancaService(int ano)
        {
            return _relatorioFinancaRepository.RelatorioSaldoTotalFinanca(ano);
        }
    }
}
