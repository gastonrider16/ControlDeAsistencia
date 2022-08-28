namespace Control_de_asistencia_2020
{
    partial class VerListadoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerListadoAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNISeleccionado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrarListadoAlumnos = new System.Windows.Forms.Button();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(362, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 47);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDNISeleccionado
            // 
            this.txtDNISeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNISeleccionado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNISeleccionado.Location = new System.Drawing.Point(420, 138);
            this.txtDNISeleccionado.Name = "txtDNISeleccionado";
            this.txtDNISeleccionado.Size = new System.Drawing.Size(146, 33);
            this.txtDNISeleccionado.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ingrese el DNI:";
            // 
            // btnCerrarListadoAlumnos
            // 
            this.btnCerrarListadoAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarListadoAlumnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarListadoAlumnos.BackgroundImage")));
            this.btnCerrarListadoAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarListadoAlumnos.Location = new System.Drawing.Point(793, -1);
            this.btnCerrarListadoAlumnos.Name = "btnCerrarListadoAlumnos";
            this.btnCerrarListadoAlumnos.Size = new System.Drawing.Size(65, 62);
            this.btnCerrarListadoAlumnos.TabIndex = 51;
            this.btnCerrarListadoAlumnos.UseVisualStyleBackColor = false;
            this.btnCerrarListadoAlumnos.Click += new System.EventHandler(this.btnCerrarListadoAlumnos_Click);
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
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoAlumnos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(253, 289);
            this.dgvListadoAlumnos.MultiSelect = false;
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.ReadOnly = true;
            this.dgvListadoAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(338, 149);
            this.dgvListadoAlumnos.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 85);
            this.label4.TabIndex = 49;
            this.label4.Text = "Listado de alumnos";
            // 
            // VerListadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNISeleccionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrarListadoAlumnos);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerListadoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerListadoAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNISeleccionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrarListadoAlumnos;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.Label label4;
    }
}