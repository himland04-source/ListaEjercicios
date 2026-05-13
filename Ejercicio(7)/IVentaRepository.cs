using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7_
{
    public interface IVentaRepository
    {
        void Agregar(Venta venta);
        List<Venta> ObtenerTodos();
    }
}
