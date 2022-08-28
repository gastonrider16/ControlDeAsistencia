namespace Control_de_asistencia_2020
{
    partial class ModificarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAlumno));
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.gpbxGuardarCambios = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.gpbxBuscarDNI = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNISeleccionado = new System.Windows.Forms.TextBox();
            this.btnCerrarModificarAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.gpbxGuardarCambios.SuspendLayout();
            this.gpbxBuscarDNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.AllowUserToAddRows = false;
            this.dgvListadoAlumnos.AllowUserToDeleteRows = false;
            this.dgvListadoAlumnos.AllowUserToResizeColumns = false;
            this.dgvListadoAlumnos.AllowUserToResizeRows = false;
            this.dgvListadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoAlumnos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(56, 300);
            this.dgvListadoAlumnos.MultiSelect = false;
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.ReadOnly = true;
            this.dgvListadoAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(338, 130);
            this.dgvListadoAlumnos.TabIndex = 49;
            // 
            // gpbxGuardarCambios
            // 
            this.gpbxGuardarCambios.Controls.Add(this.label4);
            this.gpbxGuardarCambios.Controls.Add(this.txtApellidoAlumno);
            this.gpbxGuardarCambios.Controls.Add(this.btnModificarAlumno);
            this.gpbxGuardarCambios.Controls.Add(this.label3);
            this.gpbxGuardarCambios.Controls.Add(this.txtDNI);
            this.gpbxGuardarCambios.Controls.Add(this.label2);
            this.gpbxGuardarCambios.Controls.Add(this.txtNombreAlumno);
            this.gpbxGuardarCambios.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxGuardarCambios.ForeColor = System.Drawing.Color.Red;
            this.gpbxGuardarCambios.Location = new System.Drawing.Point(447, 134);
            this.gpbxGuardarCambios.Name = "gpbxGuardarCambios";
            this.gpbxGuardarCambios.Size = new System.Drawing.Size(375, 296);
            this.gpbxGuardarCambios.TabIndex = 51;
            this.gpbxGuardarCambios.TabStop = false;
            this.gpbxGuardarCambios.Text = "Guardar cambios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Modifique el nombre:";
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoAlumno.Enabled = false;
            this.txtApellidoAlumno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAlumno.Location = new System.Drawing.Point(220, 99);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(132, 33);
            this.txtApellidoAlumno.TabIndex = 10;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarAlumno.BackgroundImage")));
            this.btnModificarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarAlumno.Enabled = false;
            this.btnModificarAlumno.Location = new System.Drawing.Point(89, 227);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(207, 47);
            this.btnModificarAlumno.TabIndex = 22;
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modifique el apellido:";
            // 
            // txtDNI
            // 
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(179, 159);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(132, 33);
            this.txtDNI.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modifque el DNI:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAlumno.Enabled = false;
            this.txtNombreAlumno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(220, 40);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(132, 33);
            this.txtNombreAlumno.TabIndex = 15;
            // 
            // gpbxBuscarDNI
            // 
            this.gpbxBuscarDNI.Controls.Add(this.btnBuscar);
            this.gpbxBuscarDNI.Controls.Add(this.label5);
            this.gpbxBuscarDNI.Controls.Add(this.txtDNISeleccionado);
            this.gpbxBuscarDNI.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxBuscarDNI.ForeColor = System.Drawing.Color.Red;
            this.gpbxBuscarDNI.Location = new System.Drawing.Point(37, 134);
            this.gpbxBuscarDNI.Name = "gpbxBuscarDNI";
            this.gpbxBuscarDNI.Size = new System.Drawing.Size(375, 157);
            this.gpbxBuscarDNI.TabIndex = 50;
            this.gpbxBuscarDNI.TabStop = false;
            this.gpbxBuscarDNI.Text = "Buscar DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(124, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 47);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // txtDNISeleccionado
            // 
            this.txtDNISeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNISeleccionado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNISeleccionado.Location = new System.Drawing.Point(197, 32);
            this.txtDNISeleccionado.Name = "txtDNISeleccionado";
            this.txtDNISeleccionado.Size = new System.Drawing.Size(146, 33);
            this.txtDNISeleccionado.TabIndex = 43;
            // 
            // btnCerrarModificarAlumno
            // 
            this.btnCerrarModificarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarModificarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarModificarAlumno.BackgroundImage")));
            this.btnCerrarModificarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarModificarAlumno.Location = new System.Drawing.Point(793, -1);
            this.btnCerrarModificarAlumno.Name = "btnCerrarModificarAlumno";
            this.btnCerrarModificarAlumno.Size = new System.Drawing.Size(65, 62);
            this.btnCerrarModificarAlumno.TabIndex = 48;
            this.btnCerrarModificarAlumno.UseVisualStyleBackColor = false;
            this.btnCerrarModificarAlumno.Click += new System.EventHandler(this.btnCerrarModificarAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 85);
            this.label1.TabIndex = 47;
            this.label1.Text = "Modificar alumno";
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.Controls.Add(this.gpbxGuardarCambios);
            this.Controls.Add(this.gpbxBuscarDNI);
            this.Controls.Add(this.btnCerrarModificarAlumno);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.gpbxGuardarCambios.ResumeLayout(false);
            this.gpbxGuardarCambios.PerformLayout();
            this.gpbxBuscarDNI.ResumeLayout(false);
            this.gpbxBuscarDNI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.GroupBox gpbxGuardarCambios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.GroupBox gpbxBuscarDNI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNISeleccionado;
        private System.Windows.Forms.Button btnCerrarModificarAlumno;
        private System.Windows.Forms.Label label1;
    }
}