using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public readonly MercadoHighTechDbContext _context;
        public ProdutoRepository()
        {
            _context = new MercadoHighTechDbContext();
        }
        public void Add(Produto entidade)
        {
            _context.Produtos.Add(entidade);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Produto paraExcluir = _context.Produtos.Find(id);
            _context.Produtos.Remove(paraExcluir);
            _context.SaveChanges();
        }
        public  IEnumerable<Produto> Get()
        {
            return _context.Produtos;
        }
        public void Update(Produto entidade)
        {
            throw new NotImplementedException();
        }


    }
}
