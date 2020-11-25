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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnHuesped = new System.Windows.Forms.RadioButton();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(105, 236);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(152, 60);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Como desea ingresar?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnHuesped);
            this.groupBox1.Controls.Add(this.radioBtnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(91, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(188, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // radioBtnHuesped
            // 
            this.radioBtnHuesped.AutoSize = true;
            this.radioBtnHuesped.Location = new System.Drawing.Point(33, 78);
            this.radioBtnHuesped.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnHuesped.Name = "radioBtnHuesped";
            this.radioBtnHuesped.Size = new System.Drawing.Size(86, 21);
            this.radioBtnHuesped.TabIndex = 1;
            this.radioBtnHuesped.TabStop = true;
            this.radioBtnHuesped.Text = "Huesped";
            this.radioBtnHuesped.UseVisualStyleBackColor = true;
            this.radioBtnHuesped.CheckedChanged += new System.EventHandler(this.radioBtnHuesped_CheckedChanged);
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Location = new System.Drawing.Point(33, 37);
            this.radioBtnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(116, 21);
            this.radioBtnAdmin.TabIndex = 0;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Administrador";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            this.radioBtnAdmin.CheckedChanged += new System.EventHandler(this.radioBtnAdmin_CheckedChanged);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.Location = new System.Drawing.Point(124, 316);
            this.btnCerrarPrograma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(117, 43);
            this.btnCerrarPrograma.TabIndex = 4;
            this.btnCerrarPrograma.Text = "Cerrar Programa";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(360, 374);
            this.Controls.Add(this.btnCerrarPrograma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Reservas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnHuesped;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.Button btnCerrarPrograma;
    }
}

