using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_4.Conexion
{
    public class Producto
    {

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        
    }
}