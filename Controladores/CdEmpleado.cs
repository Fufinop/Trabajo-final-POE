using Entidad;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CdEmpleado
    {
        string cadenaConexion = "Server=localhost;User=root;Password=root;database=Empresa";

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

        public void crear(CeEmpleado cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "INSERT INTO `pasteleria`.`empleado` (`idEmpleado`, `Nombre`, `Apellidos`, `Salario`, `Tipo`, `estatus`, `foto`) VALUES ('" + cE.Id + "', '" + cE.Nombre + "', '" + cE.Apellidos + "', '" + cE.Salario + "', '" + cE.Tipo + "', '" + cE.Estatus + "', '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto) + "');";
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

        public void editar(CeEmpleado cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "UPDATE `pasteleria`.`empleado` SET `idEmpleado`='" + cE.Id + "', `Nombre`='" + cE.Nombre + "', `Apellidos`='" + cE.Apellidos + "', `Salario`='" + cE.Salario + "', `Tipo`='" + cE.Tipo + "', `Estatus`='" + cE.Estatus + "', `Foto`='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto) + "' WHERE  `idEmpleado`=" + cE.Id + ";";
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

        public void eliminar(CeEmpleado cE)
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

        public void eliminarDatos(CeEmpleado cE)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
                mySqlConnection.Open();
                string Query = "DELETE FROM `cliente`;";
                MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                MessageBox.Show("Todos los datos han sido eliminados");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");

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

