namespace Ejercicio_8_
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMayores = new Button();
            dgvPacientes = new DataGridView();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtDiagnostico = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 148);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Diagnostico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 203);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Buscar por Nombre";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(181, 203);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(287, 203);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMayores
            // 
            btnMayores.Location = new Point(79, 249);
            btnMayores.Name = "btnMayores";
            btnMayores.Size = new Size(75, 23);
            btnMayores.TabIndex = 10;
            btnMayores.Text = "> a 60 años";
            btnMayores.UseVisualStyleBackColor = true;
            btnMayores.Click += btnMayores_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(44, 278);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(318, 150);
            dgvPacientes.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(181, 99);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 13;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(181, 149);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(100, 23);
            txtDiagnostico.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(287, 149);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(206, 249);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar Paciente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(dgvPacientes);
            Controls.Add(btnMayores);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnMayores;
        private DataGridView dgvPacientes;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtDiagnostico;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
