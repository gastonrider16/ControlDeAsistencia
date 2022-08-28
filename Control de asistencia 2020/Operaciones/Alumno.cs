using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Alumno : Conexion
    {
        Parametros[] parametrosAlumno;
        public bool agregarAlumno(Entidades.Alumno alumno)
        {
            parametrosAlumno = new Parametros[5];
            parametrosAlumno[0] = new Parametros("codAlumno", "");
            parametrosAlumno[1] = new Parametros("nomAlumno", alumno.nombre);
            parametrosAlumno[2] = new Parametros("apeAlumno", alumno.apellido);
            parametrosAlumno[3] = new Parametros("dniAlumno", alumno.dni);
            parametrosAlumno[4] = new Parametros("tipoConsulta", "agregarAlumno");
            return ejecutarProcedimiento("ABMAlumnos", parametrosAlumno);
        }
        public bool modificarAlumno(Entidades.Alumno alumno)
        {
            parametrosAlumno = new Parametros[5];
            parametrosAlumno[0] = new Parametros("codAlumno", Convert.ToString(alumno.idAlumno));
            parametrosAlumno[1] = new Parametros("nomAlumno", alumno.nombre);
            parametrosAlumno[2] = new Parametros("apeAlumno", alumno.apellido);
            parametrosAlumno[3] = new Parametros("dniAlumno", alumno.dni);
            parametrosAlumno[4] = new Parametros("tipoConsulta", "modificarAlumno");
            return ejecutarProcedimiento("ABMAlumnos", parametrosAlumno);
        }
        public bool eliminarAlumno(Entidades.Alumno alumno)
        {
            parametrosAlumno = new Parametros[5];
            parametrosAlumno[0] = new Parametros("codAlumno", Convert.ToString(alumno.idAlumno));
            parametrosAlumno[1] = new Parametros("nomAlumno", "");
            parametrosAlumno[2] = new Parametros("apeAlumno", "");
            parametrosAlumno[3] = new Parametros("dniAlumno", "");
            parametrosAlumno[4] = new Parametros("tipoConsulta", "eliminarAlumno");
            return ejecutarProcedimiento("ABMAlumnos", parametrosAlumno);
        }
        public bool listadoAlumnos(String dniSeleccionado)
        {
            parametrosAlumno = new Parametros[5];
            parametrosAlumno[0] = new Parametros("codAlumno", "");
            parametrosAlumno[1] = new Parametros("nomAlumno", "");
            parametrosAlumno[2] = new Parametros("apeAlumno", "");
            parametrosAlumno[3] = new Parametros("dniAlumno", dniSeleccionado);
            parametrosAlumno[4] = new Parametros("tipoConsulta", "listadoAlumnos");
            return ejecutarProcedimiento("ABMAlumnos", parametrosAlumno);
        }
    }
}
