using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminReservasHotel.PLayers;
using AdminReservasHotel.Model;
using System.Windows.Forms;

namespace AdminReservasHotel.Controller
{
    class CrearReserva
    {
        public void creadorReserva(frmCrearReserva form, Habitacion hab = null)
        {
            bool validado = true;

            //Datos de la reserva
            string id = form.txtIdReserva.Text;
            DateTime f_ingreso = form.dtpFechaIngreso.Value;
            DateTime f_salida = form.dtpFechaSalida.Value;
            int cant_personas = Convert.ToInt32(form.pickerCantPersonas.Value);
            bool pagado = form.rbPagAhora.Checked;

            //Datos del huesped
            string nombre = "";
            string apellido = "";
            string dni = "";
            string correo = "";
            DateTime fecha_nacimiento = form.dtpFechaNacim.Value;

            if (form.txtNombre.Text.Length == 0)
            {
                form.txtNombre.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                nombre = form.txtNombre.Text;
                form.txtNombre.BackColor = System.Drawing.Color.White;
            }

            if (form.txtApellido.Text.Length == 0)
            {
                form.txtApellido.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                apellido = form.txtApellido.Text;
                form.txtApellido.BackColor = System.Drawing.Color.White;
            }

            if (form.txtDni.Text.Length == 0)
            {
                form.txtDni.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                dni = form.txtDni.Text;
                form.txtDni.BackColor = System.Drawing.Color.White;
            }

            if (form.txtCorreo.Text.Length == 0)
            {
                form.txtCorreo.BackColor = System.Drawing.Color.Orange;
                validado = false;
            }
            else
            {
                correo = form.txtCorreo.Text;
                form.txtCorreo.BackColor = System.Drawing.Color.White;
            }
            //Creamos los objetos
            if (validado) { 
                Huesped huesp = new Huesped(nombre, apellido, dni, correo, fecha_nacimiento);

                Reserva res = new Reserva(f_ingreso, f_salida, cant_personas, pagado);
                res.agregarHabitacion(hab);
                res.asociarHuesped(huesp);

                string num_habitacion = "4F";

                //Convertimos el booleano en entero para pasarlo como parametro e insertarlo en la base de datos
                int conversion_pagado;
                if (pagado)
                    conversion_pagado = 1;
                else
                    conversion_pagado = 0;

                //Insertamos los datos de la reserva en la base de datos
                InsertData.insertarReserva(f_ingreso, f_salida, num_habitacion, dni, cant_personas, conversion_pagado);
                InsertData.insertarHuesped(nombre, apellido, dni, correo, fecha_nacimiento, Reserva.id.ToString());
            }
        }

    }
}
