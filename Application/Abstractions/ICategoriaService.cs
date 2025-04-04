﻿using Domain.Entities;

namespace Application.Abstractions
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> ObterCategorias();
        Task<Categoria> ObterCategoriaPorId(int id);
        Task AdicionarCategoria(Categoria categoria);
        Task EditarCategoria(Categoria categoria);
        Task ExcluirCategoria(int id);
    }
}
