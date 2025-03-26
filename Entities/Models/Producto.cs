using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("CategoriaProductoId")]
        public CategoriaProducto? CategoriaProducto { get; set; }
        public int? CategoriaProductoId { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
        public string? Imagen { get; set; }
        public string? Descripcion { get; set; }
    }
}
