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
    public class CategoriaController : Controller
    {
        private readonly CategoriaService _categoriaService;
        public CategoriaController()
        {
            _categoriaService = new CategoriaService();
        }
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return _categoriaService.Get();
        }
        [HttpPost]
        public void Post([FromBody] Categoria categoria)
        {
            _categoriaService.Salvar(categoria);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoriaService.Excluir(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
