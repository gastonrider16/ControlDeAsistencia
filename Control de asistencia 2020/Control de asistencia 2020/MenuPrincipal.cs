using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_asistencia_2020
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        //Con el IF de mitAgregarAlumno_Click(..) me asegura que cuando abra AgregarAlumno, no hay otro from abierto, por eso el atributo instancia debe ser ESTÁTICO
        private void mitAgregarAlumno_Click(object sender, EventArgs e)
        {
            if(!AgregarAlumno.instancia && EliminarAlumno.instancia == false && ModificarAlumno.instancia == false && VerListadoAlumno.instancia == false)
            {
                AgregarAlumno agregarAlumno = new AgregarAlumno();
                agregarAlumno.MdiParent = this;
                agregarAlumno.Show();
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mitEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (AgregarAlumno.instancia == false && !EliminarAlumno.instancia && ModificarAlumno.instancia == false && VerListadoAlumno.instancia == false)
            {
                EliminarAlumno eliminarAlumno = new EliminarAlumno();
                eliminarAlumno.MdiParent = this;
                eliminarAlumno.Show();
            }
        }

        private void mitModificarAlumno_Click(object sender, EventArgs e)
        {
            if (AgregarAlumno.instancia == false && EliminarAlumno.instancia == false && !ModificarAlumno.instancia && VerListadoAlumno.instancia == false)
            {
                ModificarAlumno modificarAlumno = new ModificarAlumno();
                modificarAlumno.MdiParent = this;
                modificarAlumno.Show();
            }
        }

        private void mitVerListadoAlumnos_Click(object sender, EventArgs e)
        {
            if (AgregarAlumno.instancia == false && EliminarAlumno.instancia == false && ModificarAlumno.instancia == false && !VerListadoAlumno.instancia)
            {
                VerListadoAlumno listadoAlumno = new VerListadoAlumno();
                listadoAlumno.MdiParent = this;
                listadoAlumno.Show();
            }
        }

    }
}
