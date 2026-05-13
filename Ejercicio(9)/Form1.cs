namespace Ejercicio_9_
{
    public partial class Form1 : Form
    {
        List<DetalleFactura> detalles = new List<DetalleFactura>();
        FacturaRepository repo = new FacturaRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            decimal total = detalles.Sum(x => x.Cantidad * x.Precio);
            lblTotal.Text = total.ToString("C");
        }
        
        private bool ValidarDetalleInputs(out decimal precio)
        {
            precio = 0m;
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.CurrentCulture, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCantidad.Focus();
                return false;
            }

            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir dígitos, separador decimal y teclas de control
            var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            char sep = decimalSeparator.Length > 0 ? decimalSeparator[0] : '.';

            if (char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == sep)
            {
                // permitir solo un separador decimal
                if (((TextBox)sender).Text.Contains(sep))
                    e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, espacios y teclas de control
            if (char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, dígitos (nombres con números), espacios y teclas de control
            if (char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar))
                return;
            e.Handled = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDetalleInputs(out decimal precio))
                return;

            var d = new DetalleFactura
            {
                Producto = txtProducto.Text.Trim(),
                Cantidad = (int)nudCantidad.Value,
                Precio = precio
            };

            detalles.Add(d);

            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = detalles.ToList();

            // recalcular total y limpiar campos
            CalcularTotal();
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            txtProducto.Focus();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (!detalles.Any())
            {
                MessageBox.Show("Agregue al menos un detalle antes de guardar la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var factura = new Factura
            {
                Cliente = txtCliente.Text.Trim(),
                Fecha = DateTime.Now,
                Detalles = detalles
            };

            try
            {
                repo.RegistrarFactura(factura);
                MessageBox.Show("Factura guardada correctamente");

                detalles.Clear();
                dgvDetalle.DataSource = null;
                lblTotal.Text = 0m.ToString("C");
                txtCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
