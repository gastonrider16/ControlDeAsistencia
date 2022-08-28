using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Parametros
    {
        public String parametro { get; set; }
        public String valor { get; set; }
        public Parametros() { }
        public Parametros(String parametro, String valor)
        {
            this.parametro = parametro;
            this.valor = valor;
        }
    }
}
