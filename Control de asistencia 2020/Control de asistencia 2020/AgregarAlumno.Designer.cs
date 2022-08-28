namespace Control_de_asistencia_2020
{
    partial class AgregarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAlumno));
            this.btnCerrarGuardarAlumno = new System.Windows.Forms.Button();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarGuardarAlumno
            // 
            this.btnCerrarGuardarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarGuardarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarGuardarAlumno.BackgroundImage")));
            this.btnCerrarGuardarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarGuardarAlumno.Location = new System.Drawing.Point(777, -1);
            this.btnCerrarGuardarAlumno.Name = "btnCerrarGuardarAlumno";
            this.btnCerrarGuardarAlumno.Size = new System.Drawing.Size(65, 62);
            this.btnCerrarGuardarAlumno.TabIndex = 37;
            this.btnCerrarGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnCerrarGuardarAlumno.Click += new System.EventHandler(this.btnCerrarGuardarAlumno_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAlumno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(425, 131);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(150, 33);
            this.txtNombreAlumno.TabIndex = 40;
            // 
            // txtDNI
            // 
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(387, 301);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(150, 33);
            this.txtDNI.TabIndex = 45;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoAlumno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAlumno.Location = new System.Drawing.Point(426, 213);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(150, 33);
            this.txtApellidoAlumno.TabIndex = 44;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarAlumno.BackgroundImage")));
            this.btnGuardarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(337, 380);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(131, 47);
            this.btnGuardarAlumno.TabIndex = 38;
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ingrese el DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ingrese el apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 85);
            this.label4.TabIndex = 39;
            this.label4.Text = "Agregar alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingrese el nombre:";
            // 
            // AgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(841, 440);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarGuardarAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarGuardarAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}