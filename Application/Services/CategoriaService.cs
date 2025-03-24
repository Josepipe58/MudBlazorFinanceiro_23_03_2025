using Application.Abstractions;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        public ICategoriaRepository _categoriaRepository;


        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task AdicionarCategoria(Categoria categoria)
        {
            await _categoriaRepository.AdicionarAsync(categoria);

        }

        public async Task EditarCategoria(Categoria categoria)
        {
            await _categoriaRepository.EditarAsync(categoria);
        }

        public async Task ExcluirCategoria(int id)
        {
            await _categoriaRepository.ExcluirAsync(id);
        }

        public async Task<Categoria> ObterCategoriaPorId(int id)
        {
            var categoria = await _categoriaRepository.ObterPorIdAsync(id);
            return categoria!;
        }

        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            return await _categoriaRepository.ObterTodosAsync();
        }
    }
}
