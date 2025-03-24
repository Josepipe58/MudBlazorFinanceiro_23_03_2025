using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class CategoriaRepository(AppDbContext context) : Repository<Categoria>(context), ICategoriaRepository
    {

    }
    /*
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public new AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto) : base(contexto)
        {
            _context = contexto;
        }
    }*/
}

