using AdminReservasHotel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel.PLayers
{
    public partial class frmCrearAdmin : Form
    {
        public frmCrearAdmin()
        {
            InitializeComponent();
        }

        private void btnCrearAdmin_Click(object sender, EventArgs e)
        {
            CrearUsuario crear_usuario = new CrearUsuario(true);

            crear_usuario.CreadorUsuario(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificarCrearAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCrearAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
