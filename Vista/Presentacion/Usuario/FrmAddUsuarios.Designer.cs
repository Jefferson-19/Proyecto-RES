using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    partial class FrmAddUsuarios
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new CuadroTexto();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx = new CuadroTexto();
            this.TxtPass = new CuadroTexto();
            this.TxtConfirmPass = new CuadroTexto();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbPerfil = new Combo_Box();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel1.SuspendLayout();
            this.Division.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Division
            // 
            // 
            // Division.Panel1
            // 
            this.Division.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.Division.Size = new System.Drawing.Size(485, 233);
            this.Division.SplitterDistance = 194;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.27685F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.72315F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Controls.Add(this.TxtNombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Tx, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtPass, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtConfirmPass, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CmbPerfil, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(485, 194);
            this.tableLayoutPanel2.TabIndex = 110;

            // 
            // TxtNombre
            // 
            this.TxtNombre.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Location = new System.Drawing.Point(155, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(261, 20);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextoVacio = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nick :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tx
            // 
            this.Tx.ColorTextoVacio = System.Drawing.Color.Gray;
            this.Tx.ForeColor = System.Drawing.Color.Red;
            this.Tx.Location = new System.Drawing.Point(155, 60);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(121, 20);
            this.Tx.TabIndex = 21;
            this.Tx.TextoVacio = "";
            // 
            // TxtPass
            // 
            this.TxtPass.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtPass.Location = new System.Drawing.Point(155, 113);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(95, 20);
            this.TxtPass.TabIndex = 22;
            this.TxtPass.TextoVacio = "";
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtConfirmPass.Location = new System.Drawing.Point(155, 139);
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.PasswordChar = '*';
            this.TxtConfirmPass.Size = new System.Drawing.Size(95, 20);
            this.TxtConfirmPass.TabIndex = 23;
            this.TxtConfirmPass.TextoVacio = "";
            this.TxtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contraseña :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reconfirmar contraseña :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Perfil :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbPerfil
            // 
            this.CmbPerfil.FormattingEnabled = true;
            this.CmbPerfil.Location = new System.Drawing.Point(155, 86);
            this.CmbPerfil.Name = "CmbPerfil";
            this.CmbPerfil.Size = new System.Drawing.Size(218, 21);
            this.CmbPerfil.TabIndex = 27;
            // 
            // FrmAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 233);
            this.Name = "FrmAds";
            this.Text = "Creación des";
            this.Load += new System.EventHandler(this.FrmAds_Load);
            this.Division.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CuadroTexto TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CuadroTexto Tx;
        private CuadroTexto TxtPass;
        private CuadroTexto TxtConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Combo_Box CmbPerfil;
    }
}