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
            string nombre = form.textBoxNombre.Text;
            string apellido = form.textBoxApellido.Text;
            string dni = form.textBoxDni.Text;
            string correo = form.textBoxCorreo.Text;
            DateTime fecha_nacimiento = form.dateTimeNacimiento.Value;
            
            
            if (this.admin_huesped) {
                
                string clave = form.textBoxClave.Text;
                //administradoresTableAdapter.InsertQuery(nombre, apellido, correo, dni, fecha_nacimiento, clave);
                Administrador admin = new Administrador(nombre, apellido, correo, dni, fecha_nacimiento, clave);
                form.textBoxClave.Text = "";
                MessageBox.Show("Administrador creado con extio!!!", "Realizado");
            }
            else
            {
                //TODO
            }

            form.textBoxNombre.Text = "";
            form.textBoxApellido.Text = "";
            form.textBoxDni.Text = "";
            form.textBoxCorreo.Text = "";
            form.dateTimeNacimiento.Value = DateTime.Today;
        }
        
    }
}
