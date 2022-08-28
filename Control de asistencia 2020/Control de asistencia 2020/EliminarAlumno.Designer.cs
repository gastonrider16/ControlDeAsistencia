namespace Control_de_asistencia_2020
{
    partial class EliminarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNISeleccionado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnCerrarEliminarAlumno = new System.Windows.Forms.Button();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(274, 198);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 47);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDNISeleccionado
            // 
            this.txtDNISeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNISeleccionado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNISeleccionado.Location = new System.Drawing.Point(423, 128);
            this.txtDNISeleccionado.Name = "txtDNISeleccionado";
            this.txtDNISeleccionado.Size = new System.Drawing.Size(146, 33);
            this.txtDNISeleccionado.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarAlumno.BackgroundImage")));
            this.btnEliminarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarAlumno.Enabled = false;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(430, 198);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(143, 47);
            this.btnEliminarAlumno.TabIndex = 43;
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnCerrarEliminarAlumno
            // 
            this.btnCerrarEliminarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarEliminarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarEliminarAlumno.BackgroundImage")));
            this.btnCerrarEliminarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarEliminarAlumno.Location = new System.Drawing.Point(793, -1);
            this.btnCerrarEliminarAlumno.Name = "btnCerrarEliminarAlumno";
            this.btnCerrarEliminarAlumno.Size = new System.Drawing.Size(65, 62);
            this.btnCerrarEliminarAlumno.TabIndex = 45;
            this.btnCerrarEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnCerrarEliminarAlumno.Click += new System.EventHandler(this.btnCerrarEliminarAlumno_Click);
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.AllowUserToAddRows = false;
            this.dgvListadoAlumnos.AllowUserToDeleteRows = false;
            this.dgvListadoAlumnos.AllowUserToResizeColumns = false;
            this.dgvListadoAlumnos.AllowUserToResizeRows = false;
            this.dgvListadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoAlumnos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(256, 285);
            this.dgvListadoAlumnos.MultiSelect = false;
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.ReadOnly = true;
            this.dgvListadoAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(338, 149);
            this.dgvListadoAlumnos.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 85);
            this.label4.TabIndex = 42;
            this.label4.Text = "Eliminar alumno";
            // 
            // EliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNISeleccionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnCerrarEliminarAlumno);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNISeleccionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnCerrarEliminarAlumno;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.Label label4;
    }
}