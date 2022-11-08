using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Controladores
{
    public class CdCliente
    {
        string cadenaConexion = "Server=localhost;User=root;Password=root;database=pasteleria";

        public void pruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse " + ex.Message);
                return;
            }

            MessageBox.Show("Conectado!");
        }
    }
}