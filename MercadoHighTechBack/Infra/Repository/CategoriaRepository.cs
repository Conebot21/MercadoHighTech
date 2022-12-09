using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public readonly MercadoHighTechDbContext _context;
        public CategoriaRepository()
        {
            _context = new MercadoHighTechDbContext();
        }
        public void Add(Categoria entidade)
        {
            _context.Categorias.Add(entidade);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Categoria paraExcluir = _context.Categorias.Find(id);
            _context.Categorias.Remove(paraExcluir);
            _context.SaveChanges();
        }
        public IEnumerable<Categoria> Get()
        {
            return _context.Categorias;
        }
        public void Update(Categoria entidade)
        {
            throw new NotImplementedException();
        }


    }
}
