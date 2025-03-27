using Domain.Entities;
using Domain.Interfaces.RelatorioInterface;
using Infrastructure.Context;

namespace Infrastructure.Repositories.RelatorioRepository
{

    public class RelatorioDespesaRepository(AppDbContext context) : Repository<RelatorioDespesaRepository>(context), IRelatorioDespesaRepository
    {
        /*
        private static string _nomeDoMetodo = string.Empty;
        private static readonly string[] despesasExtrasInformatica = ["Despesas Extras", "Informática"];
        static readonly string[] caridadeDespExtrasInfo = ["Caridade", "Despesas Extras", "Informática"];
        */
        public ListaDeMeses RelatorioDeDespesasGerais(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                meses.Janeiro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 1).Select(d => d.Valor).Sum();
                meses.Fevereiro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 2).Select(d => d.Valor).Sum();
                meses.Marco =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 3).Select(d => d.Valor).Sum();
                meses.Abril =
                   _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 4).Select(d => d.Valor).Sum();
                meses.Maio =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 5).Select(d => d.Valor).Sum();
                meses.Junho =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 6).Select(d => d.Valor).Sum();
                meses.Julho =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 7).Select(d => d.Valor).Sum();
                meses.Agosto =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 8).Select(d => d.Valor).Sum();
                meses.Setembro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 9).Select(d => d.Valor).Sum();
                meses.Outubro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 10).Select(d => d.Valor).Sum();
                meses.Novembro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 11).Select(d => d.Valor).Sum();
                meses.Dezembro =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano && d.Data.Value.Month == 12).Select(d => d.Valor).Sum();

                meses.TotalAno =
                    _context.TDespesas.Where(d => d.Data.Value.Year == ano).Select(d => d.Valor).Sum();

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception)
            {
                return [];
            }

        }

        /*
        public ListaDeMeses RelatorioDeDespesasNormais(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                meses.Janeiro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Janeiro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Janeiro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Janeiro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Janeiro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Fevereiro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Fevereiro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Fevereiro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Fevereiro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Fevereiro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Marco =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Março").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Março" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Março" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Março" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Abril =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Abril").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Abril" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Abril" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Abril" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Maio =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Maio").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Maio" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Maio" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Maio" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Junho =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Junho").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Junho" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Junho" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Junho" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Julho =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Julho").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Julho" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Julho" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Julho" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Agosto =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Agôsto").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Agôsto" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Agôsto" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Agôsto" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Setembro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Setembro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Setembro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Setembro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Setembro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Outubro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Outubro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Outubro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Outubro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Outubro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Novembro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Novembro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Novembro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Novembro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Novembro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.Dezembro =
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Dezembro").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Dezembro" && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Dezembro" && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Dezembro" && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                meses.TotalAno =
                    (_context.TDespesas.Where(d => d.Ano == ano).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Tipo == "Despesa").Select(p => p.Valor).Sum()) -
                    (_context.TDespesas.Where(d => d.Ano == ano && caridadeDespExtrasInfo.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && caridadeDespExtrasInfo.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum());

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception)
            {
                return [];
            }
        }

        public ListaDeMeses RelatorioDeDespesasExtras(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                meses.Janeiro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Janeiro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Janeiro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Fevereiro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Fevereiro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Fevereiro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Marco =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Março" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Março" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Abril =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Abril" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Abril" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Maio =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Maio" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Maio" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Junho =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Junho" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Junho" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Julho =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Julho" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Julho" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();
                meses.Agosto =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Agôsto" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Agôsto" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Setembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Setembro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Setembro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Outubro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Outubro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Outubro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Novembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Novembro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Novembro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.Dezembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Dezembro" && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Dezembro" && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                meses.TotalAno =
                    _context.TDespesas.Where(d => d.Ano == ano && despesasExtrasInformatica.Contains(d.NomeDaCategoria)).Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && despesasExtrasInformatica.Contains(p.NomeDaCategoria)).Select(p => p.Valor).Sum();

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception)
            {
                return [];
            }
        }

        public ListaDeMeses RelatorioDeDespesasDeCaridade(int ano)
        {
            try
            {
                Meses meses = new();
                ListaDeMeses listaDeMeses = [];
                meses.Janeiro =
                     _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Janeiro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                     _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Janeiro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Fevereiro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Fevereiro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Fevereiro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Marco =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Março" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Março" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Abril =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Abril" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Abril" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Maio =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Maio" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Maio" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Junho =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Junho" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Junho" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Julho =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Julho" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Julho" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Agosto =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Agôsto" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Agôsto" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Setembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Setembro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Setembro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Outubro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Outubro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Outubro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Novembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Novembro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                     _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Novembro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.Dezembro =
                    _context.TDespesas.Where(d => d.Ano == ano && d.Mes == "Dezembro" && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.Mes == "Dezembro" && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();
                meses.TotalAno =
                    _context.TDespesas.Where(d => d.Ano == ano && d.NomeDaCategoria == "Caridade").Select(d => d.Valor).Sum() +
                    _context.TFinancas.Where(p => p.Ano == ano && p.NomeDaCategoria == "Caridade").Select(p => p.Valor).Sum();

                listaDeMeses.Add(meses);

                return listaDeMeses;
            }
            catch (Exception)
            {
                return [];
            }
        }
        */
    }

}
