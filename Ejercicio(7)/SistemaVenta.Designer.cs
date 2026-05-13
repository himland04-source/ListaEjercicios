namespace Ejercicio_7_
{
    partial class SistemaVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            lblProductoMasVendido = new Label();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            dgvVentas = new DataGridView();
            lblTotalGeneral = new Label();
            lblPrdMasVendido = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 94);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 130);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 369);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Total General:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 396);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 6;
            label7.Text = "Producto más vendido:";
            // 
            // lblProductoMasVendido
            // 
            lblProductoMasVendido.AutoSize = true;
            lblProductoMasVendido.Location = new Point(146, 396);
            lblProductoMasVendido.Name = "lblProductoMasVendido";
            lblProductoMasVendido.Size = new Size(0, 15);
            lblProductoMasVendido.TabIndex = 7;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(167, 16);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 8;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(167, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(167, 94);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(167, 130);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 172);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar Venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dgvVentas
            // 
            dgvVentas.Location = new Point(28, 201);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(240, 150);
            dgvVentas.TabIndex = 0;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(136, 369);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(25, 15);
            lblTotalGeneral.TabIndex = 13;
            lblTotalGeneral.Text = "$....";
            // 
            // lblPrdMasVendido
            // 
            lblPrdMasVendido.AutoSize = true;
            lblPrdMasVendido.Location = new Point(158, 396);
            lblPrdMasVendido.Name = "lblPrdMasVendido";
            lblPrdMasVendido.Size = new Size(0, 15);
            lblPrdMasVendido.TabIndex = 14;
            // 
            // SistemaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrdMasVendido);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvVentas);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(lblProductoMasVendido);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SistemaVenta";
            Text = "Sistema de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblProductoMasVendido;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private DataGridView dgvVentas;
        private Label lblTotalGeneral;
        private Label lblPrdMasVendido;
    }
}
