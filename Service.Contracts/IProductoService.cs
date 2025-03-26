using Shared.DTOs;

namespace Service.Contracts
{
    public interface IProductoService
    {
        IEnumerable<ProductoDTO> GetProductos(bool trackChanges);
    }
}
