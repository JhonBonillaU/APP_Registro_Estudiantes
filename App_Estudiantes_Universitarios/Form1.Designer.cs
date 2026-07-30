namespace App_Estudiantes_Universitarios
{
    partial class FrmGestionEstudiantil
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboResultadoPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMostrarEstudiantes = new System.Windows.Forms.Button();
            this.btnEstudiantesDestacados = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.txtboCarrera = new System.Windows.Forms.TextBox();
            this.txtboPromedio = new System.Windows.Forms.TextBox();
            this.txtboCarnet = new System.Windows.Forms.TextBox();
            this.txtboName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txtboResultadoPromedio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnMostrarEstudiantes);
            this.groupBox1.Controls.Add(this.btnEstudiantesDestacados);
            this.groupBox1.Controls.Add(this.btnCalcularPromedio);
            this.groupBox1.Controls.Add(this.txtboCarrera);
            this.groupBox1.Controls.Add(this.txtboPromedio);
            this.groupBox1.Controls.Add(this.txtboCarnet);
            this.groupBox1.Controls.Add(this.txtboName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 838);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Estudiante";
            // 
            // txtboResultadoPromedio
            // 
            this.txtboResultadoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboResultadoPromedio.Location = new System.Drawing.Point(254, 755);
            this.txtboResultadoPromedio.Name = "txtboResultadoPromedio";
            this.txtboResultadoPromedio.Size = new System.Drawing.Size(100, 49);
            this.txtboResultadoPromedio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 755);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Promedio General de\r\nTodos los Estudiantes:";
            // 
            // btnMostrarEstudiantes
            // 
            this.btnMostrarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMostrarEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEstudiantes.Location = new System.Drawing.Point(10, 471);
            this.btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            this.btnMostrarEstudiantes.Size = new System.Drawing.Size(367, 72);
            this.btnMostrarEstudiantes.TabIndex = 11;
            this.btnMostrarEstudiantes.Text = "Mostrar Todos los Estudiantes ";
            this.btnMostrarEstudiantes.UseVisualStyleBackColor = false;
            this.btnMostrarEstudiantes.Click += new System.EventHandler(this.btnMostrarEstudiantes_Click);
            // 
            // btnEstudiantesDestacados
            // 
            this.btnEstudiantesDestacados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEstudiantesDestacados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantesDestacados.Location = new System.Drawing.Point(10, 558);
            this.btnEstudiantesDestacados.Name = "btnEstudiantesDestacados";
            this.btnEstudiantesDestacados.Size = new System.Drawing.Size(367, 72);
            this.btnEstudiantesDestacados.TabIndex = 10;
            this.btnEstudiantesDestacados.Text = "Mostrar Estudiantes Destacados";
            this.btnEstudiantesDestacados.UseVisualStyleBackColor = false;
            this.btnEstudiantesDestacados.Click += new System.EventHandler(this.btnEstudiantesDestacados_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPromedio.Location = new System.Drawing.Point(10, 651);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(367, 72);
            this.btnCalcularPromedio.TabIndex = 9;
            this.btnCalcularPromedio.Text = "Calcular Promedio General";
            this.btnCalcularPromedio.UseVisualStyleBackColor = false;
            // 
            // txtboCarrera
            // 
            this.txtboCarrera.Location = new System.Drawing.Point(10, 244);
            this.txtboCarrera.Name = "txtboCarrera";
            this.txtboCarrera.Size = new System.Drawing.Size(357, 34);
            this.txtboCarrera.TabIndex = 7;
            // 
            // txtboPromedio
            // 
            this.txtboPromedio.Location = new System.Drawing.Point(10, 326);
            this.txtboPromedio.Name = "txtboPromedio";
            this.txtboPromedio.Size = new System.Drawing.Size(357, 34);
            this.txtboPromedio.TabIndex = 6;
            // 
            // txtboCarnet
            // 
            this.txtboCarnet.Location = new System.Drawing.Point(10, 161);
            this.txtboCarnet.Name = "txtboCarnet";
            this.txtboCarnet.Size = new System.Drawing.Size(357, 34);
            this.txtboCarnet.TabIndex = 5;
            // 
            // txtboName
            // 
            this.txtboName.Location = new System.Drawing.Point(10, 75);
            this.txtboName.Name = "txtboName";
            this.txtboName.Size = new System.Drawing.Size(357, 34);
            this.txtboName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(10, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(367, 72);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar Estudiantes";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carnet / ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCarnet,
            this.colCarrera,
            this.colPromedio});
            this.dgvEstudiantes.Location = new System.Drawing.Point(20, 34);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(726, 779);
            this.dgvEstudiantes.TabIndex = 9;
            this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCarnet
            // 
            this.colCarnet.FillWeight = 75F;
            this.colCarnet.HeaderText = "Carnet";
            this.colCarnet.MinimumWidth = 6;
            this.colCarnet.Name = "colCarnet";
            this.colCarnet.ReadOnly = true;
            // 
            // colCarrera
            // 
            this.colCarrera.HeaderText = "Carrera";
            this.colCarrera.MinimumWidth = 6;
            this.colCarrera.Name = "colCarrera";
            this.colCarrera.ReadOnly = true;
            // 
            // colPromedio
            // 
            this.colPromedio.FillWeight = 75F;
            this.colPromedio.HeaderText = "Promedio";
            this.colPromedio.MinimumWidth = 6;
            this.colPromedio.Name = "colPromedio";
            this.colPromedio.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEstudiantes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(430, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 838);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Estudiantes";
            // 
            // FrmGestionEstudiantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1194, 891);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmGestionEstudiantil";
            this.Text = "Gestión Estudiantil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboCarrera;
        private System.Windows.Forms.TextBox txtboPromedio;
        private System.Windows.Forms.TextBox txtboCarnet;
        private System.Windows.Forms.TextBox txtboName;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
		private System.Windows.Forms.Button btnMostrarEstudiantes;
        private System.Windows.Forms.Button btnEstudiantesDestacados;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.TextBox txtboResultadoPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCarnet;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCarrera;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
	}
}

