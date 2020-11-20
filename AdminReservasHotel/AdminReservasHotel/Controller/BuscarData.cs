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
    class BuscarData
    {

        public bool BuscarAdministrador(Form form, bool crear_o_ingreso)
        {
            bool encontrado;
            string correo;
            if (crear_o_ingreso) { //Si se llama a la funcion desde el form para crear admin
                frmCrearAdmin frm_crear_admin = (frmCrearAdmin)form;
                correo = frm_crear_admin.txtCorreoAdmin.Text;
            }
            else //Si se llama a la funcion desde el form para ingresoAdmin
            {
                frmIngresoAdmin frm_ingreso_admin = (frmIngresoAdmin)form;
                correo = frm_ingreso_admin.txtCorreoAdmin.Text;
            }

            MySqlDataReader reader = null;

            string sql = "SELECT nombre, apellido, dni, correo, fecha_nacimiento, clave FROM administradores WHERE correo LIKE '"+correo+"' LIMIT 1";

            MySqlConnection conexion = ConexionDataBase.generarConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    encontrado = true;
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

    }
}
