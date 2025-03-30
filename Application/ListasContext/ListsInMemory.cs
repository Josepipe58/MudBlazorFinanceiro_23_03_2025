using Domain.Entities;

namespace Application.ListasContext
{
    public class ListsInMemory
    {
        public static List<Ano> TAnos()
        {
            List<Ano> listaDeAnos =
           [
                new Ano{ Id = 1, AnoDoCadastro =  DateTime.Now.Year, },
                new Ano{ Id = 2, AnoDoCadastro =  2028 },
                new Ano{ Id = 3, AnoDoCadastro =  2027 },
                new Ano{ Id = 4, AnoDoCadastro =  2026 },
                new Ano{ Id = 5, AnoDoCadastro =  2024 },
                new Ano{ Id = 6, AnoDoCadastro =  2023 },
                new Ano{ Id = 7, AnoDoCadastro =  2022 },
                new Ano{ Id = 8, AnoDoCadastro =  2021 },
                new Ano{ Id = 9, AnoDoCadastro =  2020 },
            ];

            return [.. listaDeAnos];
        }
    }
}
