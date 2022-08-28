namespace Control_de_asistencia_2020
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLUMNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAgregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitEliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitModificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVerListadoAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAgregarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mitEliminarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mitModificarMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mitListadoMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAsignarAlumnoXMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mitEliminarAlumnoXMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVerListadoAlumnoXMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.aSISTENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitTomarAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mitEliminarAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVerFaltasPorAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVerFaltasPorMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOToolStripMenuItem,
            this.mATERIAToolStripMenuItem,
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem,
            this.aSISTENCIAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLUMNOToolStripMenuItem
            // 
            this.aLUMNOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitAgregarAlumno,
            this.mitEliminarAlumno,
            this.mitModificarAlumno,
            this.mitVerListadoAlumnos});
            this.aLUMNOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLUMNOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aLUMNOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aLUMNOToolStripMenuItem.Image")));
            this.aLUMNOToolStripMenuItem.Name = "aLUMNOToolStripMenuItem";
            this.aLUMNOToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.aLUMNOToolStripMenuItem.Text = "ALUMNO";
            // 
            // mitAgregarAlumno
            // 
            this.mitAgregarAlumno.BackColor = System.Drawing.Color.Aqua;
            this.mitAgregarAlumno.ForeColor = System.Drawing.Color.Blue;
            this.mitAgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("mitAgregarAlumno.Image")));
            this.mitAgregarAlumno.Name = "mitAgregarAlumno";
            this.mitAgregarAlumno.Size = new System.Drawing.Size(168, 26);
            this.mitAgregarAlumno.Text = "AGREGAR";
            this.mitAgregarAlumno.Click += new System.EventHandler(this.mitAgregarAlumno_Click);
            // 
            // mitEliminarAlumno
            // 
            this.mitEliminarAlumno.BackColor = System.Drawing.Color.Aqua;
            this.mitEliminarAlumno.ForeColor = System.Drawing.Color.Blue;
            this.mitEliminarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("mitEliminarAlumno.Image")));
            this.mitEliminarAlumno.Name = "mitEliminarAlumno";
            this.mitEliminarAlumno.Size = new System.Drawing.Size(168, 26);
            this.mitEliminarAlumno.Text = "ELIMINAR";
            this.mitEliminarAlumno.Click += new System.EventHandler(this.mitEliminarAlumno_Click);
            // 
            // mitModificarAlumno
            // 
            this.mitModificarAlumno.BackColor = System.Drawing.Color.Aqua;
            this.mitModificarAlumno.ForeColor = System.Drawing.Color.Blue;
            this.mitModificarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("mitModificarAlumno.Image")));
            this.mitModificarAlumno.Name = "mitModificarAlumno";
            this.mitModificarAlumno.Size = new System.Drawing.Size(168, 26);
            this.mitModificarAlumno.Text = "MODIFICAR";
            this.mitModificarAlumno.Click += new System.EventHandler(this.mitModificarAlumno_Click);
            // 
            // mitVerListadoAlumnos
            // 
            this.mitVerListadoAlumnos.BackColor = System.Drawing.Color.Aqua;
            this.mitVerListadoAlumnos.ForeColor = System.Drawing.Color.Blue;
            this.mitVerListadoAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("mitVerListadoAlumnos.Image")));
            this.mitVerListadoAlumnos.Name = "mitVerListadoAlumnos";
            this.mitVerListadoAlumnos.Size = new System.Drawing.Size(168, 26);
            this.mitVerListadoAlumnos.Text = "LISTADO";
            this.mitVerListadoAlumnos.Click += new System.EventHandler(this.mitVerListadoAlumnos_Click);
            // 
            // mATERIAToolStripMenuItem
            // 
            this.mATERIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitAgregarMateria,
            this.mitEliminarMateria,
            this.mitModificarMateria,
            this.mitListadoMateria});
            this.mATERIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATERIAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mATERIAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mATERIAToolStripMenuItem.Image")));
            this.mATERIAToolStripMenuItem.Name = "mATERIAToolStripMenuItem";
            this.mATERIAToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.mATERIAToolStripMenuItem.Text = "MATERIA";
            // 
            // mitAgregarMateria
            // 
            this.mitAgregarMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitAgregarMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitAgregarMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitAgregarMateria.Image")));
            this.mitAgregarMateria.Name = "mitAgregarMateria";
            this.mitAgregarMateria.Size = new System.Drawing.Size(168, 26);
            this.mitAgregarMateria.Text = "AGREGAR";
            // 
            // mitEliminarMateria
            // 
            this.mitEliminarMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitEliminarMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitEliminarMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitEliminarMateria.Image")));
            this.mitEliminarMateria.Name = "mitEliminarMateria";
            this.mitEliminarMateria.Size = new System.Drawing.Size(168, 26);
            this.mitEliminarMateria.Text = "ELIMINAR";
            // 
            // mitModificarMateria
            // 
            this.mitModificarMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitModificarMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitModificarMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitModificarMateria.Image")));
            this.mitModificarMateria.Name = "mitModificarMateria";
            this.mitModificarMateria.Size = new System.Drawing.Size(168, 26);
            this.mitModificarMateria.Text = "MODIFICAR";
            // 
            // mitListadoMateria
            // 
            this.mitListadoMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitListadoMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitListadoMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitListadoMateria.Image")));
            this.mitListadoMateria.Name = "mitListadoMateria";
            this.mitListadoMateria.Size = new System.Drawing.Size(168, 26);
            this.mitListadoMateria.Text = "LISTADO";
            // 
            // aSIGNARALUMNOAMATERIAToolStripMenuItem
            // 
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitAsignarAlumnoXMateria,
            this.mitEliminarAlumnoXMateria,
            this.mitVerListadoAlumnoXMateria});
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aSIGNARALUMNOAMATERIAToolStripMenuItem.Image")));
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.Name = "aSIGNARALUMNOAMATERIAToolStripMenuItem";
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.Size = new System.Drawing.Size(271, 25);
            this.aSIGNARALUMNOAMATERIAToolStripMenuItem.Text = "ASIGNAR ALUMNO A MATERIA";
            // 
            // mitAsignarAlumnoXMateria
            // 
            this.mitAsignarAlumnoXMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitAsignarAlumnoXMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitAsignarAlumnoXMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitAsignarAlumnoXMateria.Image")));
            this.mitAsignarAlumnoXMateria.Name = "mitAsignarAlumnoXMateria";
            this.mitAsignarAlumnoXMateria.Size = new System.Drawing.Size(179, 26);
            this.mitAsignarAlumnoXMateria.Text = "ASIGNAR";
            // 
            // mitEliminarAlumnoXMateria
            // 
            this.mitEliminarAlumnoXMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitEliminarAlumnoXMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitEliminarAlumnoXMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitEliminarAlumnoXMateria.Image")));
            this.mitEliminarAlumnoXMateria.Name = "mitEliminarAlumnoXMateria";
            this.mitEliminarAlumnoXMateria.Size = new System.Drawing.Size(179, 26);
            this.mitEliminarAlumnoXMateria.Text = "ELIMINAR";
            // 
            // mitVerListadoAlumnoXMateria
            // 
            this.mitVerListadoAlumnoXMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitVerListadoAlumnoXMateria.ForeColor = System.Drawing.Color.Blue;
            this.mitVerListadoAlumnoXMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitVerListadoAlumnoXMateria.Image")));
            this.mitVerListadoAlumnoXMateria.Name = "mitVerListadoAlumnoXMateria";
            this.mitVerListadoAlumnoXMateria.Size = new System.Drawing.Size(179, 26);
            this.mitVerListadoAlumnoXMateria.Text = "VER LISTADO";
            // 
            // aSISTENCIAToolStripMenuItem
            // 
            this.aSISTENCIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitTomarAsistencia,
            this.mitEliminarAsistencia,
            this.mitVerFaltasPorAlumno,
            this.mitVerFaltasPorMateria});
            this.aSISTENCIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSISTENCIAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aSISTENCIAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aSISTENCIAToolStripMenuItem.Image")));
            this.aSISTENCIAToolStripMenuItem.Name = "aSISTENCIAToolStripMenuItem";
            this.aSISTENCIAToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.aSISTENCIAToolStripMenuItem.Text = "ASISTENCIA";
            // 
            // mitTomarAsistencia
            // 
            this.mitTomarAsistencia.BackColor = System.Drawing.Color.Aqua;
            this.mitTomarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("mitTomarAsistencia.Image")));
            this.mitTomarAsistencia.Name = "mitTomarAsistencia";
            this.mitTomarAsistencia.Size = new System.Drawing.Size(278, 26);
            this.mitTomarAsistencia.Text = "TOMAR ASISTENCIA";
            // 
            // mitEliminarAsistencia
            // 
            this.mitEliminarAsistencia.BackColor = System.Drawing.Color.Aqua;
            this.mitEliminarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("mitEliminarAsistencia.Image")));
            this.mitEliminarAsistencia.Name = "mitEliminarAsistencia";
            this.mitEliminarAsistencia.Size = new System.Drawing.Size(278, 26);
            this.mitEliminarAsistencia.Text = "ELIMINAR ASISTENCIA";
            // 
            // mitVerFaltasPorAlumno
            // 
            this.mitVerFaltasPorAlumno.BackColor = System.Drawing.Color.Aqua;
            this.mitVerFaltasPorAlumno.Image = ((System.Drawing.Image)(resources.GetObject("mitVerFaltasPorAlumno.Image")));
            this.mitVerFaltasPorAlumno.Name = "mitVerFaltasPorAlumno";
            this.mitVerFaltasPorAlumno.Size = new System.Drawing.Size(278, 26);
            this.mitVerFaltasPorAlumno.Text = "VER FALTAS POR ALUMNO";
            // 
            // mitVerFaltasPorMateria
            // 
            this.mitVerFaltasPorMateria.BackColor = System.Drawing.Color.Aqua;
            this.mitVerFaltasPorMateria.Image = ((System.Drawing.Image)(resources.GetObject("mitVerFaltasPorMateria.Image")));
            this.mitVerFaltasPorMateria.Name = "mitVerFaltasPorMateria";
            this.mitVerFaltasPorMateria.Size = new System.Drawing.Size(278, 26);
            this.mitVerFaltasPorMateria.Text = "VER FALTAS POR MATERIA";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitAgregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mitEliminarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mitModificarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mATERIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitAgregarMateria;
        private System.Windows.Forms.ToolStripMenuItem mitEliminarMateria;
        private System.Windows.Forms.ToolStripMenuItem mitModificarMateria;
        private System.Windows.Forms.ToolStripMenuItem mitListadoMateria;
        private System.Windows.Forms.ToolStripMenuItem aSIGNARALUMNOAMATERIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitAsignarAlumnoXMateria;
        private System.Windows.Forms.ToolStripMenuItem mitEliminarAlumnoXMateria;
        private System.Windows.Forms.ToolStripMenuItem mitVerListadoAlumnoXMateria;
        private System.Windows.Forms.ToolStripMenuItem aSISTENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitTomarAsistencia;
        private System.Windows.Forms.ToolStripMenuItem mitEliminarAsistencia;
        private System.Windows.Forms.ToolStripMenuItem mitVerFaltasPorAlumno;
        private System.Windows.Forms.ToolStripMenuItem mitVerFaltasPorMateria;
        private System.Windows.Forms.ToolStripMenuItem mitVerListadoAlumnos;
    }
}