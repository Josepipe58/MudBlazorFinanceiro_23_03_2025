using Domain.EntitiesLists;
using Domain.Interfaces.RelatorioInterface;
using Infrastructure.Context;

namespace Infrastructure.Repositories.RelatorioRepository
{
    public class RelatorioFinancaRepository(AppDbContext context) : Repository<RelatorioFinancaRepository>(context), IRelatorioFinancaRepository
    {
        
        private static readonly string[] receitaDeposito = ["Receita", "Depósito"];
        /*
        private static readonly string[] rendaCreditosPoupanca = ["Renda", "Créditos da Poupança"];
        private static readonly string[] rendaCreditosInvestimento = ["Renda de Investimentos", "Créditos de Investimentos"];
        */

        public SomarValoresDeFinanca RelatorioSaldoTotalFinanca(int ano)
        {
            try
            {
                Meses meses = new();
                SomarValoresDeFinanca SomarValoresDeFinanca = [];
                meses.Janeiro =
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 1 && f.Tipo == "Saldo Anterior").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 1 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 1 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 1 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Fevereiro =
                    meses.Janeiro +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 2 && f.Tipo == "Saldo Anterior").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 2 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 2 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 2 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Marco =
                    meses.Fevereiro +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 3 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 3 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 3 && f.Tipo == "Débito").Select(f => f.Valor).Sum());


                meses.Abril =
                    meses.Marco +
                   _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 4 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 4 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 4 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Maio =
                    meses.Abril +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 5 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 5 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 5 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Junho =
                    meses.Maio +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 6 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 6 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 6 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Julho =
                    meses.Junho +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 7 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 7 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 7 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Agosto =
                    meses.Julho +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 8 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 8 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 8 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Setembro =
                    meses.Agosto +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 9 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 9 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 9 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Outubro =
                    meses.Setembro +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 10 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 10 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 10 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Novembro =
                    meses.Outubro +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 11 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 11 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 11 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.Dezembro =
                    meses.Novembro +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 12 && receitaDeposito.Contains(f.NomeOperacao)).Select(f => f.Valor).Sum() -
                    (_context.TDespesas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 12 && f.Tipo == "Despesa de Banco").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Data.Value.Year == ano && f.Data.Value.Month == 12 && f.Tipo == "Débito").Select(f => f.Valor).Sum());

                meses.TotalAno = meses.Dezembro;

                SomarValoresDeFinanca.Add(meses);

                return SomarValoresDeFinanca;
            }
            catch (Exception)
            {
                return [];
            }
        }
        /*
        public static ListaDeMeses RelatorioDoSaldoTotalDaPoupanca(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                using var _context = new Contexto();
                meses.Janeiro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Saldo Anterior" && f.Mes == "Janeiro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Janeiro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Janeiro").Select(f => f.Valor).Sum();
                meses.Fevereiro =
                    meses.Janeiro +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Saldo Anterior" && f.Mes == "Fevereiro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Fevereiro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Fevereiro").Select(f => f.Valor).Sum();
                meses.Marco =
                    meses.Fevereiro +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Março").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Março").Select(f => f.Valor).Sum();
                meses.Abril =
                    meses.Marco +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Abril").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Abril").Select(f => f.Valor).Sum();
                meses.Maio =
                    meses.Abril +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Maio").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Maio").Select(f => f.Valor).Sum();
                meses.Junho =
                    meses.Maio +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Junho").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Junho").Select(f => f.Valor).Sum();
                meses.Julho =
                    meses.Junho +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Julho").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Julho").Select(f => f.Valor).Sum();
                meses.Agosto =
                    meses.Julho +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Agôsto").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Agôsto").Select(f => f.Valor).Sum();
                meses.Setembro =
                    meses.Agosto +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Setembro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Setembro").Select(f => f.Valor).Sum();

                meses.Outubro =
                    meses.Setembro +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Outubro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Outubro").Select(f => f.Valor).Sum();

                meses.Novembro =
                    meses.Outubro +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Novembro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Novembro").Select(f => f.Valor).Sum();

                meses.Dezembro =
                    meses.Novembro +
                    _context.TFinancas.Where(f => f.Ano == ano && rendaCreditosPoupanca.Contains(f.NomeDaCategoria) && f.Mes == "Dezembro").Select(f => f.Valor).Sum() -
                    _context.TFinancas.Where(f => f.Ano == ano && despesaDebito.Contains(f.Tipo) && f.Mes == "Dezembro").Select(f => f.Valor).Sum();
                meses.TotalAno = meses.Dezembro;

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception ex)
            {
                _nomeDoMetodo = "RelatorioDoSaldoTotalDaPoupanca";
                GerenciarMensagens.ErroDeExcecaoENomeDoMetodo(ex, _nomeDoMetodo);
                return [];
            }
        }

        public static ListaDeMeses RelatorioDosJurosDaPoupanca(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                using var _context = new Contexto();
                meses.Janeiro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Janeiro").Select(f => f.Valor).Sum();
                meses.Fevereiro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Fevereiro").Select(f => f.Valor).Sum();
                meses.Marco =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Março").Select(f => f.Valor).Sum();
                meses.Abril =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Abril").Select(f => f.Valor).Sum();
                meses.Maio =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Maio").Select(f => f.Valor).Sum();
                meses.Junho =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Junho").Select(f => f.Valor).Sum();
                meses.Julho =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Julho").Select(f => f.Valor).Sum();
                meses.Agosto =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Agôsto").Select(f => f.Valor).Sum();
                meses.Setembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Setembro").Select(f => f.Valor).Sum();
                meses.Outubro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Outubro").Select(f => f.Valor).Sum();
                meses.Novembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Novembro").Select(f => f.Valor).Sum();
                meses.Dezembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança" && f.Mes == "Dezembro").Select(f => f.Valor).Sum();
                meses.TotalAno =
                    _context.TFinancas.Where(f => f.Ano == ano && f.NomeDaSubCategoria == "Juros da Poupança").Select(f => f.Valor).Sum();

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception ex)
            {
                _nomeDoMetodo = "RelatorioDosJurosDaPoupanca";
                GerenciarMensagens.ErroDeExcecaoENomeDoMetodo(ex, _nomeDoMetodo);
                return [];
            }
        }

        public static ListaDeMeses RelatorioDosRendimentosEntreDepositosJurosESaques(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                using var _context = new Contexto();
                meses.Janeiro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Janeiro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Janeiro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Janeiro").Select(f => f.Valor).Sum());

                meses.Fevereiro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Fevereiro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Fevereiro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Fevereiro").Select(f => f.Valor).Sum());

                meses.Marco =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Março").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Março").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Março").Select(f => f.Valor).Sum());

                meses.Abril =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Abril").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Abril").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Abril").Select(f => f.Valor).Sum());

                meses.Maio =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Maio").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Maio").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Maio").Select(f => f.Valor).Sum());

                meses.Junho =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Junho").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Junho").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Junho").Select(f => f.Valor).Sum());

                meses.Julho =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Julho").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Julho").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Julho").Select(f => f.Valor).Sum());

                meses.Agosto =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Agôsto").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Agôsto").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Agôsto").Select(f => f.Valor).Sum());

                meses.Setembro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Setembro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Setembro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Setembro").Select(f => f.Valor).Sum());

                meses.Outubro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Outubro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Outubro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Outubro").Select(f => f.Valor).Sum());

                meses.Novembro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Novembro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Novembro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Novembro").Select(f => f.Valor).Sum());

                meses.Dezembro =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo) && f.Mes == "Dezembro").Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito" && f.Mes == "Dezembro").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Dezembro").Select(f => f.Valor).Sum());

                meses.TotalAno =
                    _context.TFinancas.Where(f => f.Ano == ano && new[] { "Crédito", "Receita" }.Contains(f.Tipo)).Select(f => f.Valor).Sum() -
                    (_context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Débito").Select(f => f.Valor).Sum() +
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa").Select(f => f.Valor).Sum());

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception ex)
            {
                _nomeDoMetodo = "RelatorioDosRendimentosEntreDepositosJurosESaques";
                GerenciarMensagens.ErroDeExcecaoENomeDoMetodo(ex, _nomeDoMetodo);
                return [];
            }
        }

        public static ListaDeMeses RelatorioDePagamentosETranferencias(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                using var _context = new Contexto();
                meses.Janeiro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Janeiro").Select(f => f.Valor).Sum();
                meses.Fevereiro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Fevereiro").Select(f => f.Valor).Sum();
                meses.Marco =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Março").Select(f => f.Valor).Sum();
                meses.Abril =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Abril").Select(f => f.Valor).Sum();
                meses.Maio =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Maio").Select(f => f.Valor).Sum();
                meses.Junho =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Junho").Select(f => f.Valor).Sum();
                meses.Julho =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Julho").Select(f => f.Valor).Sum();
                meses.Agosto =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Agôsto").Select(f => f.Valor).Sum();
                meses.Setembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Setembro").Select(f => f.Valor).Sum();
                meses.Outubro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Outubro").Select(f => f.Valor).Sum();
                meses.Novembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Novembro").Select(f => f.Valor).Sum();
                meses.Dezembro =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa" && f.Mes == "Dezembro").Select(f => f.Valor).Sum();
                meses.TotalAno =
                    _context.TFinancas.Where(f => f.Ano == ano && f.Tipo == "Despesa").Select(f => f.Valor).Sum();

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception ex)
            {
                _nomeDoMetodo = "RelatorioDePagamentosETranferencias";
                GerenciarMensagens.ErroDeExcecaoENomeDoMetodo(ex, _nomeDoMetodo);
                return [];
            }
        }
        */
    }
}
