using AdminReservasHotel.DataBase;
using AdminReservasHotel.PLayers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    static class BuscarData
    {

        public static bool BuscarAdministrador(Form form, bool crear_o_ingreso)
        {
            bool encontrado = false;
            string correo;
            string clave;

            if (crear_o_ingreso) { //Si se llama a la funcion desde el form para crear admin
                frmCrearAdmin frm_crear_admin = (frmCrearAdmin)form;
                correo = frm_crear_admin.txtCorreoAdmin.Text;
                clave = frm_crear_admin.txtClaveAdmin.Text;
            }
            else //Si se llama a la funcion desde el form para ingresoAdmin
            {
                frmIngresoAdmin frm_ingreso_admin = (frmIngresoAdmin)form;
                correo = frm_ingreso_admin.txtCorreoAdmin.Text;
                clave = frm_ingreso_admin.txtClaveClave.Text;
            }

            MySqlDataReader reader = null;

            string sql = "SELECT correo, clave FROM administradores WHERE correo LIKE '"+correo+"' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {                    
                    while (reader.Read())
                    {
                        if (clave == reader.GetString(1))
                            encontrado = true;
                        else
                            encontrado = false;
                    }
                    
                }
                else
                {
                    encontrado = false;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                encontrado = false;
            }
            finally
            {
                conexion.Close();
            }

            return encontrado;
        }

        public static bool BuscarHuesped(string dni)
        {
            bool encontrado = false;

            MySqlDataReader reader = null;

            string sql = "SELECT dni FROM huespedes WHERE dni LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (dni == reader.GetString(0))
                            encontrado = true;
                        else
                            encontrado = false;
                    }
                }
                else
                {
                    encontrado = false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                encontrado = false;
            }
            finally
            {
                conexion.Close();
            }

            return encontrado;
        }

        public static void BuscarResrva(frmConsultaReserva form) {
            MySqlDataReader reader = null;

            string sql = "SELECT dni FROM huespedes WHERE dni LIKE '" + dni + "' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                    }
                }
                else
                {
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                encontrado = false;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
