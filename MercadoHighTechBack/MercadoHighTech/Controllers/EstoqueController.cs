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
    public class EstoqueController : Controller
    {
        private readonly EstoqueService _estoqueService;
        public EstoqueController()
        {
            _estoqueService = new EstoqueService();
        }
        [HttpGet]
        public IEnumerable<Estoque> Get()
        {
            return _estoqueService.Get();
        }
        [HttpPost]
        public void Post([FromBody] Estoque estoque)
        {
            _estoqueService.Salvar(estoque);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _estoqueService.Excluir(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
