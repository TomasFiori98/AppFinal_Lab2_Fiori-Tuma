using AdminReservasHotel.Model;
using AdminReservasHotel.PLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    class CrearUsuario
    {
        private bool admin_huesped;

        public CrearUsuario(bool admin_huesped)
        {
            this.admin_huesped = admin_huesped;
        }

        public void CreadorUsuario(frmCrearAdmin form)
        {
            string nombre = form.txtNombre.Text;
            string apellido = form.txtApellido.Text;
            string dni = form.txtDni.Text;
            string correo = form.txtCorreoNuevo.Text;
            DateTime fecha_nacimiento = form.dateTimeNacimiento.Value;
            
            if (this.admin_huesped) {
                string clave = form.txtClaveNueva.Text;

                //Creamos el objeto administrador
                Administrador admin = new Administrador(nombre, apellido, correo, dni, fecha_nacimiento, clave);
                form.txtClaveNueva.Text = "";

                //Insertamos los datos del administrador en la base de datos
                InsertData.insertarAdministrador(nombre, apellido, dni, correo, fecha_nacimiento, clave);

                MessageBox.Show("Administrador creado con éxito!!!", "Realizado");
            }
            else
            {
                //TODO
            }

            form.txtNombre.Text = "";
            form.txtApellido.Text = "";
            form.txtDni.Text = "";
            form.txtCorreoNuevo.Text = "";
            form.dateTimeNacimiento.Value = DateTime.Today;

            

        }
        
    }
}
