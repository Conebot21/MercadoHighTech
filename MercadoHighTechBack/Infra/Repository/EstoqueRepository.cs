using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class EstoqueRepository : BaseRepository<Estoque>
    {
        public readonly MercadoHighTechDbContext _context;
        public EstoqueRepository()
        {
            _context = new MercadoHighTechDbContext();
        }
        public void Add(Estoque entidade)
        {
            _context.Estoques.Add(entidade);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Estoque paraExcluir = _context.Estoques.Find(id);
            _context.Estoques.Remove(paraExcluir);
            _context.SaveChanges();
        }
        public IEnumerable<Estoque> Get()
        {
            return _context.Estoques;
        }
        public void Update(Estoque entidade)
        {
            throw new NotImplementedException();
        }
    }
}