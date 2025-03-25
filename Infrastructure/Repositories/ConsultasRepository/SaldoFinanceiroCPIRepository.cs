using Domain.Interfaces.ConsultasInterface;
using Infrastructure.Context;

namespace Infrastructure.Repositories.ConsultasRepository
{
    public class SaldoFinanceiroCPIRepository(AppDbContext context) : Repository<SaldoFinanceiroCPIRepository>(context), ISaldoFinanceiroCPIRepository
    {
        // CPI = Carteira, Poupança e Investimento.      
        private static readonly string[] saldoRecitasEDepositos = ["Receita", "Depósito", "Saldo de Investimentos"];
        private static readonly string[] poupancaINSS = ["Poupança", "INSS"];
        private readonly string[] receitaEDeposito = ["Receita", "Depósito"];

        public decimal SaldoDaCarteiraRepository()
        {
            try
            {
                var saldoDaCarteira =
                    ((_context.TFinancas.Where(x => x.NomeOperacao == "Saldo da Carteira").Select(x => x.Valor).Sum() +
                    _context.TFinancas.Where(x => x.Descricao == "Saque").Select(x => x.Valor).Sum())) -

                    (_context.TDespesas.Where(x => x.Tipo == "Despesa de Casa").Select(x => x.Valor).Sum() +
                    _context.TFinancas.Where(x => x.NomeOperacao == "Depósito").Select(x => x.Valor).Sum());
                return saldoDaCarteira;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public decimal SaldoDaPoupancaRepository()
        {
            try
            {
                decimal saldoDaPoupanca =
                    (_context.TFinancas.Where(x => x.NomeOperacao == "Saldo da Poupança").Select(x => x.Valor).Sum() +
                    _context.TFinancas.Where(x => poupancaINSS.Contains(x.NomeFinanca) && receitaEDeposito.Contains(x.NomeOperacao)).Select(x => x.Valor).Sum()) -

                    _context.TFinancas.Where(x => x.Tipo == "Débito").Select(x => x.Valor).Sum() -
                    _context.TDespesas.Where(x => x.Tipo == "Despesa de Banco").Select(x => x.Valor).Sum();

                return saldoDaPoupanca;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public decimal SaldoDeInvestimentoRepository()
        {
            try
            {
                var saldoDeInvestimento =
                    _context.TFinancas.Where(x => x.NomeFinanca == "Investimento" && saldoRecitasEDepositos.Contains(x.NomeOperacao)).Select(x => x.Valor).Sum() -
                    _context.TFinancas.Where(x => x.NomeOperacao == "Débito de Investimentos").Select(x => x.Valor).Sum();

                return saldoDeInvestimento;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
