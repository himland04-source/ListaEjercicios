using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_9_
{
    public class Factura
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
    }

    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
