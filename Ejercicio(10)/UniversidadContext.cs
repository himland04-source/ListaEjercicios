using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Ejercicio_10_
{

    public class UniversidadContext : DbContext
    {
        static UniversidadContext()
        {
            // Crea la BD si no existe según el modelo (Code First)
            Database.SetInitializer(new CreateDatabaseIfNotExists<UniversidadContext>());
        }

        public UniversidadContext() : base("name=ConexionDB") { }

        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
