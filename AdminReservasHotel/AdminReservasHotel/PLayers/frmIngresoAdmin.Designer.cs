namespace AdminReservasHotel.PLayers
{
    partial class frmIngresoAdmin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIngresarAdmin = new System.Windows.Forms.Button();
            this.btnCrearNuevoAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnIngresarAdmin
            // 
            this.btnIngresarAdmin.Location = new System.Drawing.Point(161, 113);
            this.btnIngresarAdmin.Name = "btnIngresarAdmin";
            this.btnIngresarAdmin.Size = new System.Drawing.Size(120, 36);
            this.btnIngresarAdmin.TabIndex = 4;
            this.btnIngresarAdmin.Text = "Ingresar";
            this.btnIngresarAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCrearNuevoAdmin
            // 
            this.btnCrearNuevoAdmin.Location = new System.Drawing.Point(102, 165);
            this.btnCrearNuevoAdmin.Name = "btnCrearNuevoAdmin";
            this.btnCrearNuevoAdmin.Size = new System.Drawing.Size(240, 36);
            this.btnCrearNuevoAdmin.TabIndex = 5;
            this.btnCrearNuevoAdmin.Text = "Crear nuevo administrador";
            this.btnCrearNuevoAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(173, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmIngresoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearNuevoAdmin);
            this.Controls.Add(this.btnIngresarAdmin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoAdmin";
            this.Text = "frmIngresoAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIngresarAdmin;
        private System.Windows.Forms.Button btnCrearNuevoAdmin;
        private System.Windows.Forms.Button btnSalir;
    }
}