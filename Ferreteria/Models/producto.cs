using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ferreteria.Models
{
    public class producto
    {
        public int productoId { get; set; }
        public int categoriaId { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
    }
}