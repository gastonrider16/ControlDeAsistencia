using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Operaciones
{
    public class Conexion
    {
        private String server = "Server=localhost;";
        private String database = "DataBase=asistencia2020;";
        private String user = "User=root;";
        private String password = "Password='';";
        MySqlConnection conexion;
        public MySqlCommand comando;
        MySqlDataAdapter dataAdapter;
        public DataTable dataTable;

        public MySqlConnection conectar()
        {
            try
            {
                String cadenaDeConexion = this.server + this.database + this.user + this.password;
                conexion = new MySqlConnection(cadenaDeConexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    return conexion;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }


        public bool ejecutarProcedimiento(String storageProcedure, Parametros[] parametros)
        {
            try
            {
                comando = new MySqlCommand();
                comando.Connection = conectar();
                comando.CommandText = storageProcedure;
                comando.CommandType = CommandType.StoredProcedure;
                for (int x = 0; x < parametros.Length; x++)
                {
                    comando.Parameters.AddWithValue(parametros[x].parametro, parametros[x].valor);
                }
                dataAdapter = new MySqlDataAdapter(comando);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                desconectar();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

}
