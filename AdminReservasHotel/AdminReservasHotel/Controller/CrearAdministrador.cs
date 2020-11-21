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
    class CrearAdministrador
    {
        
        public CrearAdministrador()
        {

        }

        public void crearAdmin(frmCrearAdmin form)
        {
            string nombre;
            string apellido;
            string dni;
            string correo;
            DateTime fecha_nacimiento;

            nombre = form.txtNombre.Text;
            apellido = form.txtApellido.Text;
            dni = form.txtDni.Text;
            correo = form.txtCorreoNuevo.Text;
            fecha_nacimiento = form.dateTimeNacimiento.Value;
            string clave = form.txtClaveNueva.Text;

            //Creamos el objeto administrador
            Administrador admin = new Administrador(nombre, apellido, correo, dni, fecha_nacimiento, clave);

            //Insertamos los datos del administrador en la base de datos
            InsertData.insertarAdministrador(nombre, apellido, dni, correo, fecha_nacimiento, clave);

            //Limpiando los campos
            form.txtNombre.Text = "";
            form.txtApellido.Text = "";
            form.txtDni.Text = "";
            form.txtCorreoNuevo.Text = "";
            form.dateTimeNacimiento.Value = DateTime.Today;
            form.txtClaveNueva.Text = "";

        }

        
    }
}
