using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ProductoService: IProductoService
    {
        private readonly IRepositoryManager _repository; 
        private readonly ILoggerManager _logger;

        public ProductoService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Producto> GetProductos(bool trackChanges) 
        { 
            try 
            { 
                IEnumerable<Producto> productos = _repository.Producto.GetProductos(trackChanges); 
                return productos; 
            } 
            catch (Exception ex) 
            { 
                _logger.LogError($"Something went wrong in the {nameof(GetProductos)} service method {ex}"); 
                throw; 
            } 
        }
    }
}
