namespace AdminReservasHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHuesped = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuesped
            // 
            this.btnHuesped.Location = new System.Drawing.Point(117, 121);
            this.btnHuesped.Name = "btnHuesped";
            this.btnHuesped.Size = new System.Drawing.Size(152, 60);
            this.btnHuesped.TabIndex = 0;
            this.btnHuesped.Text = "Huesped";
            this.btnHuesped.UseVisualStyleBackColor = true;
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(117, 214);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(152, 60);
            this.btnAdministrador.TabIndex = 1;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Como desea ingresar?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(376, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnHuesped);
            this.Name = "Form1";
            this.Text = "Control de Reservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuesped;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label label1;
    }
}

