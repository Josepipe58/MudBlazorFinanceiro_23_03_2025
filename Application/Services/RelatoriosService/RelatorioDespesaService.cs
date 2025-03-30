using Application.Abstractions.RelatoriosAbstractions;
using Domain.EntitiesLists;
using Domain.Interfaces.RelatorioInterface;

namespace Application.Services.RelatoriosService
{
    public class RelatorioDespesaService : IRelatorioDespesaService
    {
        public IRelatorioDespesaRepository _relatorioDespesaRepository;

        public RelatorioDespesaService(IRelatorioDespesaRepository relatorioDespesaRepository)
        {
            _relatorioDespesaRepository = relatorioDespesaRepository;
        }

        public SomarValoresDeDespesa RelatorioDeDespesasGeraisService(int ano)
        {
            SomarValoresDeDespesa somarValoresDeDespesa = [];
            return somarValoresDeDespesa = _relatorioDespesaRepository.RelatorioDeDespesasGerais(ano);
        }
    }
}
