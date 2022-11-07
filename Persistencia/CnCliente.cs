using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class CnCliente
    {
        public MySqlConnection con;

        CnCliente()
        {
            string datos = "server=localhost;user=root;database=escuela;port=3306;password=root";
            try
            {
                con = new MySqlConnection(datos);
                con.Open();
                MessageBox.Show("Coneccion exitosa o establecida");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            


        }
    }
}