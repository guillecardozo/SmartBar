using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ProductoRepository: RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Producto> GetProductos(bool trackChanges) => 
            FindAll(trackChanges)
            .Include(c => c.CategoriaProducto)
                .OrderBy(c => c.Nombre)
            .ToList();
    }
}
