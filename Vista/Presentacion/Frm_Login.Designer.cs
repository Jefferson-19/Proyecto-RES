namespace RES.FrontEnd
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Tx
            // 
            this.Tx.Location = new System.Drawing.Point(238, 79);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(238, 132);
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.TextoVacio = "";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(347, 192);
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Imagen.Image = global::RES.FrontEnd.Properties.Resources.Timbrar;
            this.Imagen.Location = new System.Drawing.Point(1, -1);
            this.Imagen.Size = new System.Drawing.Size(214, 224);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblNombre.Location = new System.Drawing.Point(234, 57);
            // 
            // Lb
            // 
            this.Lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lb.Location = new System.Drawing.Point(235, 111);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 224);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.ShowIcon = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}