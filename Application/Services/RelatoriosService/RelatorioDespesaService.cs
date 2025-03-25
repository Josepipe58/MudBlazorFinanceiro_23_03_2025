using Application.Abstractions.RelatoriosAbstractions;
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

        public ListaDeMeses RelatorioDeDespesasGeraisService(int ano)
        {
            ListaDeMeses listaDeMeses = [];
            return listaDeMeses = _relatorioDespesaRepository.RelatorioDeDespesasGerais(ano);
        }
    }
}
