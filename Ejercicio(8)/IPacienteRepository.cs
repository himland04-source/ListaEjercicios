using System.Collections.Generic;

namespace Ejercicio_8_
{
    public interface IPacienteRepository
    {
        void Agregar(Paciente paciente);
        List<Paciente> ObtenerTodos();
        List<Paciente> BuscarPorNombre(string nombre);
        List<Paciente> MayoresDe60();
        void Eliminar(int id); 
    }
}
