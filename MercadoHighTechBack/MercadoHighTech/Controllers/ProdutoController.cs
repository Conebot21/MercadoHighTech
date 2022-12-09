using Infra.Entidades;
using Infra.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace MercadoHighTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;
        public ProdutoController()
        {
             _produtoService = new ProdutoService();
        }
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _produtoService.Get();
        }
        [HttpPost]
        public void Post([FromBody] Produto produto)
        {
            _produtoService.Salvar(produto);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _produtoService.Excluir(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
