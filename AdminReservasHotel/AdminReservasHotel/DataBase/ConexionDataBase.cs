using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AdminReservasHotel.DataBase
{
    class ConexionDataBase
    {
        public static MySqlConnection generarConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd=1234; database=dbsistema;");
                return conexion;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public bool probarConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd=1234; database=dbsistema;");

            try
            {
                conexion.Open();

                MessageBox.Show("Conectado");

                conexion.Close();

                return true;

            } catch (MySqlException ex)
            {
                conexion.Close();

                MessageBox.Show(ex.ToString());

                return false;
            }
            
        }


    }
}
