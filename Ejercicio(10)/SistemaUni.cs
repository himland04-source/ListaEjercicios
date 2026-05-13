using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace Ejercicio_10_
{
    public partial class SistemaUni : Form
    {
        private UniversidadContext db;

        // Rango válido de edad
        private const int EdadMinima = 15;
        private const int EdadMaxima = 120;

        public SistemaUni()
        {
            InitializeComponent();
            db = new UniversidadContext();
            this.FormClosing += Form1_FormClosing;

            CargarCarreras();
            CargarEstudiantes();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarCarreras()
        {
            try
            {
                var carreras = db.Carreras
                    .OrderBy(c => c.NombreCarrera)
                    .ToList();

                // No compartir el mismo DataSource entre controles
                cmbCarreras.DataSource = carreras.ToList();
                cmbCarreras.DisplayMember = "NombreCarrera";
                cmbCarreras.ValueMember = "Id";
                cmbCarreras.SelectedIndex = -1;

                cmbFiltroCarrera.DataSource = carreras.ToList();
                cmbFiltroCarrera.DisplayMember = "NombreCarrera";
                cmbFiltroCarrera.ValueMember = "Id";
                cmbFiltroCarrera.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar las carreras: {ex.Message}");
            }
        }

        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            string nombre = txtCarrera.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarError("Ingrese el nombre de la carrera.");
                txtCarrera.Focus();
                return;
            }

            if (nombre.Length > 100)
            {
                MostrarError("El nombre de la carrera es demasiado largo (máx. 100 caracteres).");
                txtCarrera.Focus();
                return;
            }

            try
            {
                bool existe = db.Carreras.Any(c => c.NombreCarrera.Equals(nombre, StringComparison.CurrentCultureIgnoreCase));
                if (existe)
                {
                    MostrarError("Ya existe una carrera con ese nombre.");
                    return;
                }

                var c = new Carrera { NombreCarrera = nombre };
                db.Carreras.Add(c);
                db.SaveChanges();

                MostrarInformacion("Carrera guardada correctamente.");
                txtCarrera.Clear();
                CargarCarreras();
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo guardar la carrera: {ex.Message}");
            }
        }

        private void CargarEstudiantes()
        {
            try
            {
                var lista = db.Estudiantes
                    .Include(e => e.Carrera)
                    .Select(x => new
                    {
                        x.Id,
                        x.Nombre,
                        x.Edad,
                        Carrera = x.Carrera != null ? x.Carrera.NombreCarrera : string.Empty
                    })
                    .ToList();

                dgvEstudiantes.AutoGenerateColumns = true;
                dgvEstudiantes.DataSource = lista;
                dgvEstudiantes.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar estudiantes: {ex.Message}");
            }
        }

        private void btnGuardarEstudiantes_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarError("Ingrese el nombre del estudiante.");
                txtNombre.Focus();
                return;
            }

            if (nombre.Length > 100)
            {
                MostrarError("El nombre es demasiado largo (máx. 100 caracteres).\n");
                txtNombre.Focus();
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MostrarError("Ingrese una edad válida (número entero). ");
                txtEdad.Focus();
                return;
            }

            if (edad < EdadMinima || edad > EdadMaxima)
            {
                MostrarError($"La edad debe estar entre {EdadMinima} y {EdadMaxima}.");
                txtEdad.Focus();
                return;
            }

            if (cmbCarreras.SelectedValue == null || !int.TryParse(cmbCarreras.SelectedValue.ToString(), out int carreraId))
            {
                MostrarError("Seleccione una carrera válida.");
                cmbCarreras.Focus();
                return;
            }

            try
            {
                var est = new Estudiante
                {
                    Nombre = nombre,
                    Edad = edad,
                    CarreraId = carreraId
                };

                db.Estudiantes.Add(est);
                db.SaveChanges();

                MostrarInformacion("Estudiante guardado correctamente.");
                txtNombre.Clear();
                txtEdad.Clear();
                cmbCarreras.SelectedIndex = -1;
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MostrarError($"No se pudo guardar el estudiante: {ex.Message}");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltroCarrera.SelectedValue == null || !int.TryParse(cmbFiltroCarrera.SelectedValue.ToString(), out int carreraId))
                {
                    // Si no hay filtro seleccionado, mostrar todos
                    CargarEstudiantes();
                    return;
                }

                var lista = db.Estudiantes
                    .Where(x => x.CarreraId == carreraId)
                    .Include(e => e.Carrera)
                    .Select(x => new
                    {
                        x.Nombre,
                        x.Edad,
                        Carrera = x.Carrera != null ? x.Carrera.NombreCarrera : string.Empty
                    })
                    .ToList();

                dgvEstudiantes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MostrarError($"Error al aplicar el filtro: {ex.Message}");
            }
        }

        private void SistemaUni_Load(object sender, EventArgs e)
        {

        }

        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MostrarError("Ingrese una edad válida (número entero). ");
                txtEdad.Focus();
                return;
            }
        }
    }
}
