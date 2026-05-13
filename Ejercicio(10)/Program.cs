using System;
using System.Windows.Forms;

namespace Ejercicio_10_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Fuerza creación/inicialización de la BD antes de abrir el formulario
            using (var db = new Ejercicio_10_.UniversidadContext())
            {
                db.Database.Initialize(force: true);
            }

            Application.Run(new SistemaUni());
        }
    }
}