using Application.Abstractions.ConsultasAbstractions;
using Domain.Interfaces.ConsultasInterface;

namespace Application.Services.ConsultasService
{
    public class SaldoFinanceiroCPIService : ISaldoFinanceiroCPIService
    {
        protected readonly ISaldoFinanceiroCPIRepository _saldoFinanceiroCPIRepository;

        public SaldoFinanceiroCPIService() { }

        public SaldoFinanceiroCPIService(ISaldoFinanceiroCPIRepository saldoFinanceiroCPIRepository)
        {
            _saldoFinanceiroCPIRepository = saldoFinanceiroCPIRepository;
        }

        public decimal SaldoDaCarteira()
        {
            return _saldoFinanceiroCPIRepository.SaldoDaCarteiraRepository();
        }
        public decimal SaldoDaPoupanca()
        {
            return _saldoFinanceiroCPIRepository.SaldoDaPoupancaRepository();
        }

        public decimal SaldoDeInvestimento()
        {
            return _saldoFinanceiroCPIRepository.SaldoDeInvestimentoRepository();
        }
    }
}
