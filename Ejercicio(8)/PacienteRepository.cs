using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicio_8_
{
    public class PacienteRepository : IPacienteRepository
    {

        private string conexion = "Data Source=localhost;Initial Catalog=master;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public void Agregar(Paciente paciente)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Pacientes (Nombre, Edad, Diagnostico) VALUES (@Nombre,@Edad,@Diagnostico)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                cmd.Parameters.AddWithValue("@Diagnostico", paciente.Diagnostico);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> lista = new List<Paciente>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pacientes", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Paciente
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Edad = (int)dr["Edad"],
                        Diagnostico = dr["Diagnostico"].ToString()
                    });
                }
            }
            return lista;
        }

        public List<Paciente> BuscarPorNombre(string nombre)
        {
            return ObtenerTodos()
                   .Where(x => x.Nombre.ToLower().Contains(nombre.ToLower()))
                   .ToList();
        }

        public List<Paciente> MayoresDe60()
        {
            return ObtenerTodos()
                   .Where(x => x.Edad > 60)
                   .ToList();
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Pacientes WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
