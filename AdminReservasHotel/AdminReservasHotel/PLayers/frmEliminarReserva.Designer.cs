namespace AdminReservasHotel.PLayers
{
    partial class frmEliminarReserva
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvEliminarReserva = new System.Windows.Forms.DataGridView();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.txtDniTitular = new System.Windows.Forms.TextBox();
            this.txtCorreoTitular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(163, 323);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 29);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvEliminarReserva
            // 
            this.dgvEliminarReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarReserva.Location = new System.Drawing.Point(38, 171);
            this.dgvEliminarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEliminarReserva.Name = "dgvEliminarReserva";
            this.dgvEliminarReserva.RowHeadersWidth = 51;
            this.dgvEliminarReserva.RowTemplate.Height = 24;
            this.dgvEliminarReserva.Size = new System.Drawing.Size(327, 141);
            this.dgvEliminarReserva.TabIndex = 16;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(163, 125);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(71, 28);
            this.btnBuscarReserva.TabIndex = 15;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            // 
            // txtDniTitular
            // 
            this.txtDniTitular.Location = new System.Drawing.Point(149, 92);
            this.txtDniTitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDniTitular.Name = "txtDniTitular";
            this.txtDniTitular.Size = new System.Drawing.Size(168, 20);
            this.txtDniTitular.TabIndex = 14;
            // 
            // txtCorreoTitular
            // 
            this.txtCorreoTitular.Location = new System.Drawing.Point(149, 59);
            this.txtCorreoTitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoTitular.Name = "txtCorreoTitular";
            this.txtCorreoTitular.Size = new System.Drawing.Size(168, 20);
            this.txtCorreoTitular.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dni del titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Correo del titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese los datos del titular para buscar la reserva y luego eliminarla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliminar una reserva";
            // 
            // frmEliminarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(393, 366);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvEliminarReserva);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.txtDniTitular);
            this.Controls.Add(this.txtCorreoTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEliminarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEliminarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvEliminarReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.TextBox txtDniTitular;
        private System.Windows.Forms.TextBox txtCorreoTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}