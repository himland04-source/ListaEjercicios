using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7_
{
    public class Venta
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        // Propiedad calculada
        public decimal Total => Cantidad * Precio;
    }
}
