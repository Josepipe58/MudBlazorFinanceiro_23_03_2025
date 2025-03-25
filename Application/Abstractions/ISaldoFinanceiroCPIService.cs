namespace Application.Abstractions
{
    public interface ISaldoFinanceiroCPIService
    {
        double SaldoDaCarteira();

        double SaldoDaPoupanca();

        double SaldoDeInvestimento();
    }
}
