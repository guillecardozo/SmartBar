using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class ProductoRepository: RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Producto> GetProductos(bool trackChanges) => 
            FindAll(trackChanges)
                .OrderBy(c => c.Nombre)
            .ToList();
    }
}
