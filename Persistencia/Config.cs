using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class Config
    {
        public MySqlConnection con;

        Config()
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