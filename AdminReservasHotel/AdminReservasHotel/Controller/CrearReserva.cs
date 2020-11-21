using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminReservasHotel.PLayers;
using AdminReservasHotel.Model;

namespace AdminReservasHotel.Controller
{
    class CrearReserva
    {
        

        public void creadorReserva(frmCrearReserva frm, Habitacion hab = null)
        {
            //Datos de la reserva
            string id = frm.txtIdReserva.Text;
            DateTime f_ingreso = frm.dtpFechaIngreso.Value;
            DateTime f_salida = frm.dtpFechaSalida.Value;
            int cant_personas = Convert.ToInt32(frm.pickerCantPersonas.Value);
            bool pagado = frm.rbPagAhora.Checked;

            //Datos del huesped
            string nombre = frm.txtNombre.Text;
            string apellido = frm.txtApellido.Text;
            string dni = frm.txtDni.Text;
            string correo = frm.txtCorreo.Text;
            DateTime fecha_nacimiento = frm.dtpFechaNacim.Value;
            string id_reserva = frm.txtIdReserva.Text;

            Reserva.id++;

            //Creamos los objetos
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
            InsertData.insertarReserva(Reserva.id, f_ingreso, f_salida, num_habitacion, dni, cant_personas, conversion_pagado) ;

        }

    }
}
