using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTOs;

namespace SmartBar.Presentation.Controllers
{
    [Route("api/productos")]
    [ApiController] 
    public class ProdcutosController : ControllerBase 
    {
        private readonly IServiceManager _service; 
        public ProdcutosController(IServiceManager service) => _service = service; 
        [HttpGet] 
        public IActionResult GetProductos() 
        { 
            try 
            { 
                IEnumerable<ProductoDTO> productos = _service.ProductoService.GetProductos(trackChanges: false); 
                return Ok(productos); 
            } 
            catch 
            { 
                return StatusCode(500, "Internal server error"); 
            } 
        }
    }
}
