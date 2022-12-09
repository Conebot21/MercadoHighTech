using Infra.Entidades;
using Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _repositorio;
        public ProdutoService()
        {
            _repositorio = new ProdutoRepository();
        }
        public IEnumerable<Produto> Get()
        {
            return _repositorio.Get();
        }
        public void Salvar(Produto produto)
        {
            EstoqueService estoqueService = new EstoqueService();
            //estoqueService.AtualizarEstoque();
            _repositorio.Add(produto);
        }
        public void Excluir(int id)
        {
            _repositorio.Delete(id);
        }

    }
}
