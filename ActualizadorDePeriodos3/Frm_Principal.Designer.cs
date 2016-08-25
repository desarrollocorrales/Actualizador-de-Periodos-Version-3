namespace ActualizadorDePeriodos3
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txbContrasenia = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.pnltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(202, 229);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(156, 188);
            this.nudPuerto.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(120, 27);
            this.nudPuerto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Puerto:";
            // 
            // txbContrasenia
            // 
            this.txbContrasenia.Location = new System.Drawing.Point(156, 155);
            this.txbContrasenia.Name = "txbContrasenia";
            this.txbContrasenia.PasswordChar = '*';
            this.txbContrasenia.Size = new System.Drawing.Size(185, 27);
            this.txbContrasenia.TabIndex = 21;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(156, 122);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(185, 27);
            this.txbUsuario.TabIndex = 20;
            // 
            // txbBaseDeDatos
            // 
            this.txbBaseDeDatos.Location = new System.Drawing.Point(156, 89);
            this.txbBaseDeDatos.Name = "txbBaseDeDatos";
            this.txbBaseDeDatos.Size = new System.Drawing.Size(310, 27);
            this.txbBaseDeDatos.TabIndex = 19;
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(156, 56);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(250, 27);
            this.txbServidor.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Base de datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Servidor:";
            // 
            // pnltitulo
            // 
            this.pnltitulo.Controls.Add(this.lblTitulo);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Size = new System.Drawing.Size(504, 50);
            this.pnltitulo.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(151, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configurar Conexion";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(504, 271);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContrasenia);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbBaseDeDatos);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnltitulo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Principal";
            this.Text = "Actualizador de periodos";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.pnltitulo.ResumeLayout(false);
            this.pnltitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbContrasenia;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbBaseDeDatos;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}

