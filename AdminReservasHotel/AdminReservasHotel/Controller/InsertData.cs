using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminReservasHotel.PLayers;
using AdminReservasHotel.DataBase;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    class InsertData
    {

        public static void insertarAdministrador(string nombre, string apellido, string dni, string correo, DateTime fecha_nacimiento, string clave)
        {

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            string sql = "INSERT INTO administradores (nombre, apellido, dni, correo, fecha_nacimiento, clave) VALUES " +
                "('" + nombre + "','" + apellido + "','" + dni + "','" + correo + "','" + fecha_nacimiento + "','" + clave + "')";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente!!");
            } catch (MySqlException ex) {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }



    }
}
