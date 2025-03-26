using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                IEnumerable<Producto> productos = _service.ProductoService.GetProductos(trackChanges: false); 
                return Ok(productos); 
            } 
            catch 
            { 
                return StatusCode(500, "Internal server error"); 
            } 
        }
    }
}
