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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnConsultarRes = new System.Windows.Forms.Button();
            this.dgvConsultarReserva = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su correo electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(256, 48);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(229, 22);
            this.txtCorreo.TabIndex = 2;
            // 
            // btnConsultarRes
            // 
            this.btnConsultarRes.Location = new System.Drawing.Point(173, 90);
            this.btnConsultarRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarRes.Name = "btnConsultarRes";
            this.btnConsultarRes.Size = new System.Drawing.Size(127, 36);
            this.btnConsultarRes.TabIndex = 3;
            this.btnConsultarRes.Text = "Consultar";
            this.btnConsultarRes.UseVisualStyleBackColor = true;
            // 
            // dgvConsultarReserva
            // 
            this.dgvConsultarReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarReserva.Location = new System.Drawing.Point(16, 146);
            this.dgvConsultarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultarReserva.Name = "dgvConsultarReserva";
            this.dgvConsultarReserva.RowHeadersWidth = 51;
            this.dgvConsultarReserva.RowTemplate.Height = 24;
            this.dgvConsultarReserva.Size = new System.Drawing.Size(469, 249);
            this.dgvConsultarReserva.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(209, 401);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsultarReserva);
            this.Controls.Add(this.btnConsultarRes);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnConsultarRes;
        private System.Windows.Forms.DataGridView dgvConsultarReserva;
        private System.Windows.Forms.Button btnSalir;
    }
}