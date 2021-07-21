using RES.FrontEnd.ControlesPersonalizado;

namespace RES.FrontEnd
{
    partial class Control_Acceso
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Lb = new System.Windows.Forms.Label();
            this.Tx = new RES.FrontEnd.ControlesPersonalizado.CuadroTexto();
            this.TxtPassword = new RES.FrontEnd.ControlesPersonalizado.CuadroTexto();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.Image = global::RES.FrontEnd.Properties.Resources.Timbrar;
            this.Imagen.Location = new System.Drawing.Point(16, 22);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(184, 201);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(217, 54);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(114, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Pon aquí tu texto";
            // 
            // Lb
            // 
            this.Lb.AutoSize = true;
            this.Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb.Location = new System.Drawing.Point(218, 108);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(114, 17);
            this.Lb.TabIndex = 2;
            this.Lb.Text = "Pon aquí tu texto";
            // 
            // Tx
            // 
            this.Tx.ColorTextoVacio = System.Drawing.Color.Gray;
            this.Tx.Location = new System.Drawing.Point(221, 76);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(175, 20);
            this.Tx.TabIndex = 3;
            this.Tx.TextoVacio = "<Descripcion>";
            // 
            // TxtPassword
            // 
            this.TxtPassword.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(221, 129);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(153, 20);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TextoVacio = "<Descripcion>";
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(350, 200);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Control_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 236);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.Tx);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.Imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Control_Acceso";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Control_Acceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CuadroTexto Tx;
        public CuadroTexto TxtPassword;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.PictureBox Imagen;
        public System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.Label Lb;
    }
}
