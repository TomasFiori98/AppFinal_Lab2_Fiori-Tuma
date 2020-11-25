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
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO!";
            // 
            // btnConsultaReserva
            // 
            this.btnConsultaReserva.Location = new System.Drawing.Point(92, 125);
            this.btnConsultaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultaReserva.Name = "btnConsultaReserva";
            this.btnConsultaReserva.Size = new System.Drawing.Size(181, 43);
            this.btnConsultaReserva.TabIndex = 1;
            this.btnConsultaReserva.Text = "Consultar tu reserva";
            this.btnConsultaReserva.UseVisualStyleBackColor = true;
            this.btnConsultaReserva.Click += new System.EventHandler(this.btnConsultaReserva_Click);
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(92, 172);
            this.btnConsultarDisponibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(181, 43);
            this.btnConsultarDisponibilidad.TabIndex = 2;
            this.btnConsultarDisponibilidad.Text = "Consultar disponibilidad";
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = true;
            this.btnConsultarDisponibilidad.Click += new System.EventHandler(this.btnConsultarDisponibilidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Que desea hacer?";
            // 
            // btnHuespedSalir
            // 
            this.btnHuespedSalir.Location = new System.Drawing.Point(136, 267);
            this.btnHuespedSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuespedSalir.Name = "btnHuespedSalir";
            this.btnHuespedSalir.Size = new System.Drawing.Size(96, 36);
            this.btnHuespedSalir.TabIndex = 4;
            this.btnHuespedSalir.Text = "Salir";
            this.btnHuespedSalir.UseVisualStyleBackColor = true;
            this.btnHuespedSalir.Click += new System.EventHandler(this.btnHuespedSalir_Click);
            // 
            // frmHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(370, 356);
            this.Controls.Add(this.btnHuespedSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarDisponibilidad);
            this.Controls.Add(this.btnConsultaReserva);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huesped";
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