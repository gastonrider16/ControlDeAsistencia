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
    public partial class AgregarAlumno : Form
    {
        public static bool instancia = false; 
        public AgregarAlumno()
        {
            InitializeComponent();
            instancia = true;
        }

        private void btnCerrarGuardarAlumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            instancia = false;
        }
    }
}
