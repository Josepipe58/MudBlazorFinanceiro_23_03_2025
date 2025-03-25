namespace Domain.Interfaces.ConsultasInterface
{
    public interface ISaldoFinanceiroCPIRepository
    {
        decimal SaldoDaCarteiraRepository();

        decimal SaldoDaPoupancaRepository();

        decimal SaldoDeInvestimentoRepository();
    }
}
