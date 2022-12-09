using Infra.Entidades;
using Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class EstoqueService
    {
        private readonly EstoqueRepository _repositorio;
        public EstoqueService()
        {
            _repositorio = new EstoqueRepository();
        }
        public IEnumerable<Estoque> Get()
        {
            return _repositorio.Get();
        }
        public void Salvar(Estoque estoque)
        {
            EstoqueService estoqueService = new EstoqueService();
            //estoqueService.AtualizarEstoque();
            _repositorio.Add(estoque);
        }
        public void Excluir(int id)
        {
            _repositorio.Delete(id);
        }
    }
}
