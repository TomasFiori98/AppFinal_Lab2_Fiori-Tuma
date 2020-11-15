namespace AdminReservasHotel.PLayers
{
    partial class frmHuesped
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
            this.btnConsultaReserva = new System.Windows.Forms.Button();
            this.btnConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuespedSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO!";
            // 
            // btnConsultaReserva
            // 
            this.btnConsultaReserva.Location = new System.Drawing.Point(104, 104);
            this.btnConsultaReserva.Name = "btnConsultaReserva";
            this.btnConsultaReserva.Size = new System.Drawing.Size(181, 43);
            this.btnConsultaReserva.TabIndex = 1;
            this.btnConsultaReserva.Text = "Consultar tu reserva";
            this.btnConsultaReserva.UseVisualStyleBackColor = true;
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(104, 177);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(181, 43);
            this.btnConsultarDisponibilidad.TabIndex = 2;
            this.btnConsultarDisponibilidad.Text = "Consultar disponibilidad";
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Que desea hacer?";
            // 
            // btnHuespedSalir
            // 
            this.btnHuespedSalir.Location = new System.Drawing.Point(163, 272);
            this.btnHuespedSalir.Name = "btnHuespedSalir";
            this.btnHuespedSalir.Size = new System.Drawing.Size(75, 23);
            this.btnHuespedSalir.TabIndex = 4;
            this.btnHuespedSalir.Text = "Salir";
            this.btnHuespedSalir.UseVisualStyleBackColor = true;
            // 
            // frmHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(395, 363);
            this.Controls.Add(this.btnHuespedSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarDisponibilidad);
            this.Controls.Add(this.btnConsultaReserva);
            this.Controls.Add(this.label1);
            this.Name = "frmHuesped";
            this.Text = "frmHuesped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaReserva;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuespedSalir;
    }
}