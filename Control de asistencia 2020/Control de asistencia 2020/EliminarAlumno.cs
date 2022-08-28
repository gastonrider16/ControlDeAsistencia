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
    public partial class EliminarAlumno : Form
    {
        public static bool instancia = false;
        public EliminarAlumno()
        {
            InitializeComponent();
            instancia = true;
        }

        private void btnCerrarEliminarAlumno_Click(object sender, EventArgs e)
        {
            instancia = false;
            this.Hide();
        }
    }
}
