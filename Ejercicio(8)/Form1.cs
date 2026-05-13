namespace Ejercicio_8_
{
    public partial class Form1 : Form
    {
        IPacienteRepository repo = new PacienteRepository();
        public Form1()
        {
            InitializeComponent();
            // Attach input restrictions
            txtEdad.KeyPress += TxtEdad_KeyPress;
            txtNombre.KeyPress += TxtNombre_KeyPress;
            txtDiagnostico.KeyPress += TxtDiagnostico_KeyPress;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // Load initial data
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = repo.ObtenerTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = repo.BuscarPorNombre(txtBuscar.Text);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEdad.Text) || !int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad es obligatoria y debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (edad < 0 || edad > 120)
            {
                MessageBox.Show("Ingrese una edad válida (0-120).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("El diagnóstico es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiagnostico.Focus();
                return;
            }

            var p = new Paciente
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = edad,
                Diagnostico = txtDiagnostico.Text.Trim()
            };

            repo.Agregar(p);
            CargarDatos();
            // Limpiar campos después de guardar
            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
        }

        // Permitir sólo dígitos en Edad
        private void TxtEdad_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // permitir control (backspace), números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtNombre_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtBuscar_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtDiagnostico_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = repo.MayoresDe60();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dataItem = dgvPacientes.CurrentRow.DataBoundItem;
            if (dataItem is not Paciente paciente)
            {
                MessageBox.Show("Seleccione una fila válida.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"¿Eliminar a '{paciente.Nombre}' (Id={paciente.Id})?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            if (repo is PacienteRepository concreteRepo)
            {
                try
                {
                    concreteRepo.Eliminar(paciente.Id);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El repositorio actual no soporta eliminación directa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
