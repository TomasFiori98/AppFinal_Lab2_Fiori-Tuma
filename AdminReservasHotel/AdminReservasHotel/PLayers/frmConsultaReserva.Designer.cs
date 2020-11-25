namespace AdminReservasHotel.PLayers
{
    partial class frmConsultaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnConsultarRes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNHabitacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigoId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el D.N.I:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(168, 47);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(151, 22);
            this.txtDni.TabIndex = 2;
            // 
            // btnConsultarRes
            // 
            this.btnConsultarRes.Location = new System.Drawing.Point(132, 84);
            this.btnConsultarRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarRes.Name = "btnConsultarRes";
            this.btnConsultarRes.Size = new System.Drawing.Size(127, 36);
            this.btnConsultarRes.TabIndex = 3;
            this.btnConsultarRes.Text = "Consultar";
            this.btnConsultarRes.UseVisualStyleBackColor = true;
            this.btnConsultarRes.Click += new System.EventHandler(this.btnConsultarRes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(132, 442);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos de su reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(179, 209);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(20, 17);
            this.lblFechaIngreso.TabIndex = 8;
            this.lblFechaIngreso.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Salida:";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(179, 248);
            this.lblFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(20, 17);
            this.lblFechaSalida.TabIndex = 10;
            this.lblFechaSalida.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Habitacion:";
            // 
            // lblNHabitacion
            // 
            this.lblNHabitacion.AutoSize = true;
            this.lblNHabitacion.Location = new System.Drawing.Point(179, 288);
            this.lblNHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNHabitacion.Name = "lblNHabitacion";
            this.lblNHabitacion.Size = new System.Drawing.Size(20, 17);
            this.lblNHabitacion.TabIndex = 12;
            this.lblNHabitacion.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 334);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cantidad de Personas:";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(179, 334);
            this.lblCantidadPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(20, 17);
            this.lblCantidadPersonas.TabIndex = 16;
            this.lblCantidadPersonas.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 379);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Estado de pago:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(179, 379);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(20, 17);
            this.lblPago.TabIndex = 14;
            this.lblPago.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo de reserva: ";
            // 
            // lblCodigoId
            // 
            this.lblCodigoId.AutoSize = true;
            this.lblCodigoId.Location = new System.Drawing.Point(179, 172);
            this.lblCodigoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoId.Name = "lblCodigoId";
            this.lblCodigoId.Size = new System.Drawing.Size(20, 17);
            this.lblCodigoId.TabIndex = 19;
            this.lblCodigoId.Text = "...";
            // 
            // frmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(379, 517);
            this.Controls.Add(this.lblCodigoId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblNHabitacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarRes);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarRes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblCodigoId;
        internal System.Windows.Forms.Label lblFechaIngreso;
        internal System.Windows.Forms.Label lblFechaSalida;
        internal System.Windows.Forms.Label lblNHabitacion;
        internal System.Windows.Forms.Label lblCantidadPersonas;
        internal System.Windows.Forms.Label lblPago;
    }
}