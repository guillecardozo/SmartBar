using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Producto>? Producto { get; set; }
        public DbSet<CategoriaProducto>? CategoriaProducto { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }
        public DbSet<DetallePedido>? DetallePedido { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }


    }
}
