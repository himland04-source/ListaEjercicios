using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicio_9_
{

    public class FacturaRepository
    {
        private string conexion = "Data Source=localhost;Initial Catalog=master;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public void RegistrarFactura(Factura factura)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                // 🔥 INICIAR TRANSACCIÓN
                SqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    // 1. Insertar factura
                    string queryFactura = "INSERT INTO Facturas (Cliente, Fecha) OUTPUT INSERTED.Id VALUES (@Cliente, @Fecha)";
                    SqlCommand cmdFactura = new SqlCommand(queryFactura, conn, transaccion);

                    cmdFactura.Parameters.AddWithValue("@Cliente", factura.Cliente);
                    cmdFactura.Parameters.AddWithValue("@Fecha", factura.Fecha);

                    int facturaId = (int)cmdFactura.ExecuteScalar();

                    // 2. Insertar detalles
                    foreach (var d in factura.Detalles)
                    {
                        string queryDetalle = "INSERT INTO DetalleFactura (FacturaId, Producto, Cantidad, Precio) VALUES (@FacturaId, @Producto, @Cantidad, @Precio)";
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn, transaccion);

                        cmdDetalle.Parameters.AddWithValue("@FacturaId", facturaId);
                        cmdDetalle.Parameters.AddWithValue("@Producto", d.Producto);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@Precio", d.Precio);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    // ✅ TODO BIEN → COMMIT
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    // ❌ ERROR → ROLLBACK
                    transaccion.Rollback();
                    throw;
                }
            }
        }
    }
}
