namespace Ejercicio_10_
{
    partial class SistemaUni
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
            groupBox1 = new GroupBox();
            btnGuardarCarrera = new Button();
            txtCarrera = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGuardarEstudiantes = new Button();
            cmbCarreras = new ComboBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            dgvEstudiantes = new DataGridView();
            btnFiltrar = new Button();
            cmbFiltroCarrera = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarCarrera);
            groupBox1.Controls.Add(txtCarrera);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 88);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(687, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carreras";
            // 
            // btnGuardarCarrera
            // 
            btnGuardarCarrera.Location = new Point(392, 65);
            btnGuardarCarrera.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCarrera.Name = "btnGuardarCarrera";
            btnGuardarCarrera.Size = new Size(79, 31);
            btnGuardarCarrera.TabIndex = 2;
            btnGuardarCarrera.Text = "Guardar";
            btnGuardarCarrera.UseVisualStyleBackColor = true;
            btnGuardarCarrera.Click += btnGuardarCarrera_Click;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(157, 61);
            txtCarrera.Margin = new Padding(3, 4, 3, 4);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(202, 27);
            txtCarrera.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre Carrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 41);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 1;
            label1.Text = "Sistema Universitario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuardarEstudiantes);
            groupBox2.Controls.Add(cmbCarreras);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(39, 249);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(687, 168);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estudiantes";
            // 
            // btnGuardarEstudiantes
            // 
            btnGuardarEstudiantes.Location = new Point(251, 105);
            btnGuardarEstudiantes.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEstudiantes.Name = "btnGuardarEstudiantes";
            btnGuardarEstudiantes.Size = new Size(135, 31);
            btnGuardarEstudiantes.TabIndex = 6;
            btnGuardarEstudiantes.Text = "Guardar Estudiante";
            btnGuardarEstudiantes.UseVisualStyleBackColor = true;
            btnGuardarEstudiantes.Click += btnGuardarEstudiantes_Click;
            // 
            // cmbCarreras
            // 
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(498, 35);
            cmbCarreras.Margin = new Padding(3, 4, 3, 4);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(138, 28);
            cmbCarreras.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(299, 35);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(86, 26);
            txtEdad.TabIndex = 4;
            txtEdad.KeyPress += SoloNum;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(93, 35);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 26);
            txtNombre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label5.Location = new Point(437, 45);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 2;
            label5.Text = "Carrera:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label4.Location = new Point(251, 45);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 1;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label3.Location = new Point(13, 45);
            label3.Name = "label3";
            label3.Size = new Size(66, 16);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvEstudiantes);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Controls.Add(cmbFiltroCarrera);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(42, 455);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(683, 412);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtrar";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(50, 101);
            dgvEstudiantes.Margin = new Padding(3, 4, 3, 4);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(597, 276);
            dgvEstudiantes.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(296, 44);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 31);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cmbFiltroCarrera
            // 
            cmbFiltroCarrera.FormattingEnabled = true;
            cmbFiltroCarrera.Location = new Point(119, 44);
            cmbFiltroCarrera.Margin = new Padding(3, 4, 3, 4);
            cmbFiltroCarrera.Name = "cmbFiltroCarrera";
            cmbFiltroCarrera.Size = new Size(138, 28);
            cmbFiltroCarrera.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 44);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Carrrera";
            // 
            // SistemaUni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 897);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SistemaUni";
            Text = "Sistema Universitario";
            Load += SistemaUni_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGuardarCarrera;
        private TextBox txtCarrera;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGuardarEstudiantes;
        private ComboBox cmbCarreras;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private DataGridView dgvEstudiantes;
        private Button btnFiltrar;
        private ComboBox cmbFiltroCarrera;
        private Label label6;
    }
}
