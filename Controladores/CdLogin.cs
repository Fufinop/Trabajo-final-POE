using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CdLogin
    {
        string cadenaConexion = "Server=localhost;User=root;Password=root;database=Empresa";

        public void ComprobarUsuario(CeLogin cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "SELECT * FROM users WHERE LoginName = '"+ cE.LoginName +"' AND PASSWORD = '"+ cE.Password +"';";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                MessageBox.Show("Usuario correcto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
