using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    partial class FrmModGrupos
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
            this.CmbTipoGrupo = new Combo_Box();
            this.TxtNGrupo = new CuadroTexto();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Division.Size = new System.Drawing.Size(403, 168);
            this.Division.SplitterDistance = 130;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel2.Controls.Add(this.CmbTipoGrupo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtNGrupo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(403, 130);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CmbTipoGrupo
            // 
            this.CmbTipoGrupo.FormattingEnabled = true;
            this.CmbTipoGrupo.Location = new System.Drawing.Point(126, 41);
            this.CmbTipoGrupo.Name = "CmbTipoGrupo";
            this.CmbTipoGrupo.Size = new System.Drawing.Size(193, 21);
            this.CmbTipoGrupo.TabIndex = 0;
            this.CmbTipoGrupo.SelectedIndexChanged += new System.EventHandler(this.CmbTipoGrupo_SelectedIndexChanged);
            // 
            // TxtNGrupo
            // 
            this.TxtNGrupo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNGrupo.Location = new System.Drawing.Point(126, 68);
            this.TxtNGrupo.Name = "TxtNGrupo";
            this.TxtNGrupo.Size = new System.Drawing.Size(240, 20);
            this.TxtNGrupo.TabIndex = 1;
            this.TxtNGrupo.TextoVacio = "Nombre nuevo grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Grupo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAddGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 168);
            this.Name = "FrmAddGrupos";
            this.Text = "Modificar Grupo";
            this.Load += new System.EventHandler(this.FrmAddGrupos_Load);
            this.Division.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Combo_Box CmbTipoGrupo;
        private CuadroTexto TxtNGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}