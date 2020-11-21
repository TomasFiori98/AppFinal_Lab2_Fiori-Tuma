namespace AdminReservasHotel.PLayers
{
    partial class frmAdministrador
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
            this.btnConsultarReserva = new System.Windows.Forms.Button();
            this.btnConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.btnCrearNuevaReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnAdminSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido de vuelta admin!";
            // 
            // btnConsultarReserva
            // 
            this.btnConsultarReserva.Location = new System.Drawing.Point(161, 78);
            this.btnConsultarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReserva.Name = "btnConsultarReserva";
            this.btnConsultarReserva.Size = new System.Drawing.Size(212, 49);
            this.btnConsultarReserva.TabIndex = 1;
            this.btnConsultarReserva.Text = "Consultar reserva";
            this.btnConsultarReserva.UseVisualStyleBackColor = true;
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(161, 132);
            this.btnConsultarDisponibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(212, 49);
            this.btnConsultarDisponibilidad.TabIndex = 2;
            this.btnConsultarDisponibilidad.Text = "Consultar disponibilidad";
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // btnCrearNuevaReserva
            // 
            this.btnCrearNuevaReserva.Location = new System.Drawing.Point(161, 187);
            this.btnCrearNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearNuevaReserva.Name = "btnCrearNuevaReserva";
            this.btnCrearNuevaReserva.Size = new System.Drawing.Size(212, 49);
            this.btnCrearNuevaReserva.TabIndex = 3;
            this.btnCrearNuevaReserva.Text = "Crear nueva reserva";
            this.btnCrearNuevaReserva.UseVisualStyleBackColor = true;
            this.btnCrearNuevaReserva.Click += new System.EventHandler(this.btnCrearNuevaReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(161, 242);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(212, 49);
            this.btnEliminarReserva.TabIndex = 4;
            this.btnEliminarReserva.Text = "Eliminar reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // btnAdminSalir
            // 
            this.btnAdminSalir.Location = new System.Drawing.Point(235, 354);
            this.btnAdminSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminSalir.Name = "btnAdminSalir";
            this.btnAdminSalir.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSalir.TabIndex = 5;
            this.btnAdminSalir.Text = "Salir";
            this.btnAdminSalir.UseVisualStyleBackColor = true;
            this.btnAdminSalir.Click += new System.EventHandler(this.btnAdminSalir_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.btnAdminSalir);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnCrearNuevaReserva);
            this.Controls.Add(this.btnConsultarDisponibilidad);
            this.Controls.Add(this.btnConsultarReserva);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarReserva;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.Button btnCrearNuevaReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnAdminSalir;
    }
}