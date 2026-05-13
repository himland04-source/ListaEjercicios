using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Ejercicio_7_
{
    public class VentaRepository : IVentaRepository
    {
        private string conexion = "Data Source=localhost;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public void Agregar(Venta venta)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Ventas (Cliente, Producto, Cantidad, Precio) VALUES (@Cliente,@Producto,@Cantidad,@Precio)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
                cmd.Parameters.AddWithValue("@Producto", venta.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", venta.Precio);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Venta> ObtenerTodos()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Venta
                    {
                        Id = (int)dr["Id"],
                        Cliente = dr["Cliente"].ToString(),
                        Producto = dr["Producto"].ToString(),
                        Cantidad = (int)dr["Cantidad"],
                        Precio = (decimal)dr["Precio"]
                    });
                }
            }
            return lista;
        }
    }
}
