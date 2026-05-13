namespace Ejercicio_7_
{
    public partial class SistemaVenta : Form
    {
        IVentaRepository repo = new VentaRepository();
        public SistemaVenta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void CalcularTotalGeneral()
        {
            var lista = repo.ObtenerTodos();
            decimal total = lista.Sum(x => x.Total);
            lblTotalGeneral
                .Text = total.ToString("C");
        }
        private void ProductoMasVendido()
        {
            var lista = repo.ObtenerTodos();

            var producto = lista
                .GroupBy(x => x.Producto)
                .OrderByDescending(g => g.Sum(x => x.Cantidad))
                .FirstOrDefault();

            if (producto != null)
            {
                lblPrdMasVendido.Text = producto.Key;
            }
        }
        private void CargarDatos()
        {
            var lista = repo.ObtenerTodos();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = lista;

            // Opcional: mostrar también el Total en una columna
            dgvVentas.Columns["Total"].Visible = true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                Cliente = txtCliente.Text,
                Producto = txtProducto.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = decimal.Parse(txtPrecio.Text)
            };

            repo.Agregar(v);
            CargarDatos();
            CalcularTotalGeneral();
            ProductoMasVendido();
        }
    }
}
