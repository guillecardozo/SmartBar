using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
        public int? ClienteId { get; set; }
        public bool Canjeado { get; set; }
    }
}
