using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager 
    { 
        private readonly RepositoryContext _repositoryContext; 
        private readonly Lazy<IProductoRepository> _productoRepository; 
        public RepositoryManager(RepositoryContext repositoryContext) 
        { 
            _repositoryContext = repositoryContext;
            _productoRepository = new Lazy<IProductoRepository>(() => new ProductoRepository(repositoryContext)); 
        } 

        public IProductoRepository Producto => _productoRepository.Value; 
        public void Save() => _repositoryContext.SaveChanges(); 
    }
}
