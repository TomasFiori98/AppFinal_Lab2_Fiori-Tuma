using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminReservasHotel.Model
{
    class Reserva
    {
        private string id;
        private DateTime fecha_ingreso;
        private DateTime fecha_salida;
        private Habitacion habitacion;
        private Huesped titular_reserva;
        private int cant_personas;
        private bool pagado;

        public Reserva(string id, DateTime fecha_ingreso, DateTime fecha_salida, int cant_personas, bool pagado)
        {
            this.id = id;
            this.fecha_ingreso = fecha_ingreso;
            this.fecha_salida = fecha_salida;
            this.cant_personas = cant_personas;
            this.pagado = pagado;
        }

        public void agregarHabitacion(Habitacion hab)
        {
            this.habitacion = hab;
        }
        public void asociarHuesped(Huesped hu)
        {
            this.titular_reserva = hu;
        }

        public void mostrarDatos()
        {

        }


    }
}
