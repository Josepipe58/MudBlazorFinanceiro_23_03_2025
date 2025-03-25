namespace Application.Abstractions.ConsultasAbstractions
{
    public interface ISaldoFinanceiroCPIService
    {
        decimal SaldoDaCarteira();

        decimal SaldoDaPoupanca();

        decimal SaldoDeInvestimento();
    }
}
