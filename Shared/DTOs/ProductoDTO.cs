using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record ProductoDTO(int Id, string? Nombre, string? Categoria, decimal? Precio, bool Activo, string? Descripcion);
}
