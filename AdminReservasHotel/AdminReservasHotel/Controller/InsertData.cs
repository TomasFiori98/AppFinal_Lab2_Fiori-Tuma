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
    static class InsertData
    {

        public static void insertarAdministrador(string nombre, string apellido, string dni, string correo, DateTime fecha_nacimiento, string clave)
        {

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            string sql = "INSERT INTO administradores (nombre, apellido, dni, correo, fecha_nacimiento, clave) VALUES " +
                "('" + nombre + "','" + apellido + "','" + dni + "','" + correo + "','" + fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "','" + clave + "')";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Administrador agregado correctamente!!", "Realizado");
            } catch (MySqlException ex) {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        public static void insertarHuesped(string nombre, string apellido, string dni, string correo, DateTime fecha_nacimiento, string idReserva)
        {

            MySqlConnection con = ConexionDataBase.generarConexion();
            con.Open();

            string sql = "INSERT INTO huespedes (nombre, apellido, dni, correo, fecha_nacimiento, id_reserva) VAUES " +
                "('"+ nombre +"','" + apellido + "','" + dni + "','" + correo + "','" + fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss") + "','" + idReserva + "')";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Huesped agregado correctamente!!", "Realizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al enviar el huesped a la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public static void insertarReserva(int id_reserva, DateTime f_ingreso, DateTime f_salida, string num_habitacion, string dni_titular, int cant_personas, int pagado)
        {
            MySqlConnection con = ConexionDataBase.generarConexion();
            con.Open();

            string sql = "INSERT INTO huespedes (id_reserva, fecha_ingreso, fecha_salida, numero_habitacion, dni_titular, cant_personas, pagado) VAUES " +
                "('" + id_reserva + "','" + f_ingreso.ToString("yyyy-MM-dd HH:mm:ss") + "','" + f_salida.ToString("yyyy-MM-dd HH:mm:ss") + "','" + num_habitacion + "','" + dni_titular + "','" + cant_personas + "', '" + pagado + "')";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reserva agregada correctamente!!", "Realizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al enviar la reserva a la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
