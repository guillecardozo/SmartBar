using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTOs;

namespace Service
{
    internal sealed class ProductoService: IProductoService
    {
        private readonly IRepositoryManager _repository; 
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductoService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProductoDTO> GetProductos(bool trackChanges) 
        { 
            try 
            { 
                IEnumerable<Producto> productos = _repository.Producto.GetProductos(trackChanges);

                IEnumerable<ProductoDTO> productosDto = _mapper.Map<IEnumerable<ProductoDTO>>(productos);

                return productosDto;
            } 
            catch (Exception ex) 
            { 
                _logger.LogError($"Something went wrong in the {nameof(GetProductos)} service method {ex}"); 
                throw; 
            } 
        }
    }
}
