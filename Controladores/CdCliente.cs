using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Modelos;
using System.Data;

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
            mySqlConnection.Close();
            MessageBox.Show("Conectado!");
        }

        public void crear(CeCliente cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "INSERT INTO `pasteleria`.`cliente` (`idCliente`, `nombre`, `apellidos`, `direccion`, `cedula`, `telefono`, `Email`, `estatus`, `foto`) VALUES ('" + cE.Id + "', '" + cE.Nombre + "', '" + cE.Apellidos + "', '" + cE.Direccion + "', '" + cE.Cedula + "', '" + cE.Telefono + "', '" + cE.Email + "', '" + cE.Estatus + "', '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto) + "');";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                MessageBox.Show("Registro creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error o repetiste el id");

            }
            
        }

        public void editar(CeCliente cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "UPDATE `pasteleria`.`cliente` SET `idCliente`='" + cE.Id + "', `direccion`='" + cE.Direccion + "', `cedula`='" + cE.Cedula + "', `telefono`='" + cE.Telefono + "', `Email`='" + cE.Email + "', `estatus`='" + cE.Estatus + "', `foto`='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto) + "' WHERE  `idCliente`=" + cE.Id + ";";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                MessageBox.Show("Registro actualizado");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error o repetiste el id");

            }

        }

        public void eliminar(CeCliente cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "DELETE FROM `cliente` WHERE  `idCliente`=" + cE.Id + ";";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error o repetiste el id");

            }

        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string Querry = "SELECT * FROM cliente LIMIT 1000;";
            MySqlDataAdapter adaptador;
            DataSet dataset = new DataSet();

            adaptador = new MySqlDataAdapter(Querry, mySqlConnection);
            adaptador.Fill(dataset, "tb1");


            return dataset;
        }
    }
}