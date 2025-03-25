using Application.Abstractions;
using Infrastructure.Context;

namespace Application.Consultas
{
    public class SaldoFinanceiroCPIService : ISaldoFinanceiroCPIService
    {
        // CPI = Carteira, Poupança e Investimento.      
        private static readonly string[] saldoRecitasEDepositos = ["Receita", "Depósito", "Saldo de Investimentos"];
        private static readonly string[] poupancaINSS = ["Poupança", "INSS"];
        private readonly string[] receitaEDeposito = ["Receita","Depósito"];
        protected readonly AppDbContext _contexto;

        public SaldoFinanceiroCPIService(){}

        public SaldoFinanceiroCPIService(AppDbContext contexto)
        {
            _contexto = contexto; 
        }

        public double SaldoDaCarteira()
        {
            try
            {
                var saldoDaCarteira =
                    ((_contexto.TFinancas.Where(x => x.NomeOperacao == "Saldo da Carteira").Select(x => x.Valor).Sum() +                    
                    _contexto.TFinancas.Where(x => x.Descricao == "Saque").Select(x => x.Valor).Sum())) -

                    (_contexto.TDespesas.Where(x => x.Tipo == "Despesa de Casa").Select(x => x.Valor).Sum() +
                    _contexto.TFinancas.Where(x => x.NomeOperacao == "Depósito").Select(x => x.Valor).Sum());

                return  Convert.ToDouble(saldoDaCarteira);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public double SaldoDaPoupanca()
        {
            try
            {
                var saldoDaPoupanca =
                    (_contexto.TFinancas.Where(x => x.NomeOperacao == "Saldo da Poupança").Select(x => x.Valor).Sum() +                    
                    _contexto.TFinancas.Where(x => poupancaINSS.Contains(x.NomeFinanca) && receitaEDeposito.Contains(x.NomeOperacao)).Select(x => x.Valor).Sum()) -

                    _contexto.TFinancas.Where(x => x.Tipo == "Débito").Select(x => x.Valor).Sum() -
                    _contexto.TDespesas.Where(x => x.Tipo == "Despesa de Banco").Select(x => x.Valor).Sum();

                return Convert.ToDouble(saldoDaPoupanca);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        public double SaldoDeInvestimento()
        {
            try
            {
                var saldoDeInvestimento =
                    _contexto.TFinancas.Where(x => x.NomeFinanca =="Investimento" && saldoRecitasEDepositos.Contains(x.NomeOperacao)).Select(x => x.Valor).Sum() -
                    _contexto.TFinancas.Where(x => x.NomeOperacao == "Débito de Investimentos").Select(x => x.Valor).Sum();

                return Convert.ToDouble(saldoDeInvestimento);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
