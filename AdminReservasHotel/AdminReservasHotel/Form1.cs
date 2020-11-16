﻿using AdminReservasHotel.Controller;
using AdminReservasHotel.PLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminReservasHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Mostrando form de administrador
            if (radioBtnAdmin.Checked)
            {
                frmIngresoAdmin formIngAdmin = new frmIngresoAdmin();
                formIngAdmin.ShowDialog();
            }
            //Mostrando form de administrador
            else
            {
                frmHuesped form_huesped = new frmHuesped();
                form_huesped.ShowDialog();
            }
        }

        private void radioBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
