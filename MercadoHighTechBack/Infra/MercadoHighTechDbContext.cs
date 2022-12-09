using Infra.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infra
{
    public class MercadoHighTechDbContext : DbContext
    {
        public MercadoHighTechDbContext() : base()
        {

        }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8O8S6E4\SQLEXPRESS;Database=mercadoHighTech;Trusted_Connection=True;");
        }
    }
}
