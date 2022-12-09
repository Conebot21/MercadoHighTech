using Infra.Entidades;
using Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class CategoriaService
    {
        private readonly CategoriaRepository _repositorio;
        public CategoriaService()
        {
            _repositorio = new CategoriaRepository();
        }
        public IEnumerable<Categoria> Get()
        {
            return _repositorio.Get();
        }
        public void Salvar(Categoria categoria)
        {
            EstoqueService estoqueService = new EstoqueService();
            //estoqueService.AtualizarEstoque();
            _repositorio.Add(categoria);
        }
        public void Excluir(int id)
        {
            _repositorio.Delete(id);
        }
    }
}
