using Domain.Interfaces.RelatorioInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.RelatoriosAbstractions
{
    public interface IRelatorioDespesaService
    {
        ListaDeMeses RelatorioDeDespesasGeraisService(int ano);
    }
}
