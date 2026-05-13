namespace Ejercicio_9_
{
    partial class Form1
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
            txtCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProducto = new TextBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            btnGuardarFactura = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPrecio = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            label8 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 99);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(148, 91);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 1;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 19);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 2;
            label2.Text = "DETALLE FACTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 19);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 3;
            label3.Text = "Detalle Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 81);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 81);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Cantidad";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-92, -47);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "Precio";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(46, 119);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(94, 23);
            txtProducto.TabIndex = 7;
            txtProducto.KeyPress += txtProducto_KeyPress;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(152, 120);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(66, 23);
            nudCantidad.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(318, 118);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(46, 22);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(347, 164);
            dgvDetalle.TabIndex = 13;
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.Location = new Point(179, 575);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(127, 23);
            btnGuardarFactura.TabIndex = 14;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = true;
            btnGuardarFactura.Click += btnGuardarFactura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 153);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Factura";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(nudCantidad);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Location = new Point(12, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 167);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detella";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(224, 120);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(88, 23);
            txtPrecio.TabIndex = 14;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 81);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 13;
            label7.Text = "Precio";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDetalle);
            groupBox3.Location = new Point(12, 361);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 208);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 620);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 18;
            label8.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(200, 620);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "$0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 657);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarFactura);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProducto;
        private TextBox textBox3;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Button btnGuardarFactura;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtPrecio;
        private Label label8;
        private Label lblTotal;
    }
}
