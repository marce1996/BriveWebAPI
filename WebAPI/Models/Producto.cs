using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public int IdSucursal { get; set; }
        public string NombreProducto { get; set; }
        public int SKU { get; set; }
    }
}
