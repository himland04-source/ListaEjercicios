using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_10_
{
    public class Carrera
    {
        public int Id { get; set; }
        public string NombreCarrera { get; set; } = "";

        // Relación
        public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public int Edad { get; set; }
        public int CarreraId { get; set; }
        public virtual Carrera? Carrera { get; set; }
    }
}
