using Domain.Entities;
using Domain.EntitiesLists;

namespace Infrastructure.ListasContext
{
    public static class BancoDeListas
    {
        public static readonly IEnumerable<BuscarAno> TAnos =
        [
            new BuscarAno{ Id = 1, Ano =  DateTime.Now.Year, },
            new BuscarAno{ Id = 2, Ano =  2028 },
            new BuscarAno{ Id = 3, Ano =  2027 },
            new BuscarAno{ Id = 4, Ano =  2026 },
            new BuscarAno{ Id = 5, Ano =  2024 },
            new BuscarAno{ Id = 6, Ano =  2023 },
            new BuscarAno{ Id = 7, Ano =  2022 },
            new BuscarAno{ Id = 8, Ano =  2021 },
            new BuscarAno{ Id = 9, Ano =  2020 },
        ];
        
        public static readonly IEnumerable<NomeDeFinanca> TNomeDeFinancas =
        [
            new NomeDeFinanca{ Id = 1, Nome =  "Poupança", },
            new NomeDeFinanca{ Id = 2, Nome =  "INSS", },
            new NomeDeFinanca{ Id = 3, Nome =  "Investimento", },
            new NomeDeFinanca{ Id = 4, Nome =  "Outros", },
        ];

        public static readonly IEnumerable<NomeDeOperacao> TNomeDeOperacoes =
        [
            new NomeDeOperacao{ Id = 1, Nome =  "Receita",},
            new NomeDeOperacao{ Id = 2, Nome =  "Débito da Poupança",},
            new NomeDeOperacao{ Id = 3, Nome =  "Depósito",},
            new NomeDeOperacao{ Id = 4, Nome =  "Saldo da Carteira",},
            new NomeDeOperacao{ Id = 5, Nome =  "Saldo da Poupança",},
            new NomeDeOperacao{ Id = 6, Nome =  "Reembolso",},
            new NomeDeOperacao{ Id = 7, Nome =  "Débito de Investimentos",},
            new NomeDeOperacao{ Id = 8, Nome =  "Saldo de Investimentos"},
        ];

        public static readonly IEnumerable<NomeDeTipo> TNomeDeTipos =
       [
            new NomeDeTipo{ Id = 1, Nome = "Crédito"},
            new NomeDeTipo{ Id = 2, Nome = "Renda"},
            new NomeDeTipo{ Id = 3, Nome = "Débito"},
            new NomeDeTipo{ Id = 4, Nome = "Carteira"},
            new NomeDeTipo{ Id = 5, Nome = "Saldo Anterior"},
        ];

        //TCategorias já existe no Banco De Dados.
        public static readonly IEnumerable<Categoria> TCategorias =
        [
            new Categoria{ Id = 1, NomeCategoria = "Alimentação"},       
            new Categoria{ Id = 2, NomeCategoria = "Bazar"},
            new Categoria{ Id = 3, NomeCategoria = "Bebidas"},
            new Categoria{ Id = 4, NomeCategoria = "Cama, Mesa e Banho"},
            new Categoria{ Id = 5, NomeCategoria = "Caridade"},
            new Categoria{ Id = 6, NomeCategoria = "Contas Básicas"},
            new Categoria{ Id = 7, NomeCategoria = "Despesas Extras"},
            new Categoria{ Id = 8, NomeCategoria = "Diversão"},
            new Categoria{ Id = 9, NomeCategoria = "Diversos"},
            new Categoria{ Id = 10, NomeCategoria = "Higiene Pessoal"},
            new Categoria{ Id = 11, NomeCategoria = "Informática"},
            new Categoria{ Id = 12, NomeCategoria = "Limpeza"},
            new Categoria{ Id = 13, NomeCategoria = "Manutenção Geral"},
            new Categoria{ Id = 14, NomeCategoria = "Saúde"},
            new Categoria{ Id = 15, NomeCategoria = "Transportes"},
            new Categoria{ Id = 16, NomeCategoria = "Utensílios Domésticos"},
            new Categoria{ Id = 17, NomeCategoria = "Vestuário"},
        ];
    }
}
    

