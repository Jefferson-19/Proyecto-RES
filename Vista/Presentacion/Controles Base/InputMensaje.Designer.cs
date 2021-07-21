using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    partial class InputMensaje
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtIn = new RES.FrontEnd.ControlesPersonalizado.CuadroTexto();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.ToolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel1.SuspendLayout();
            this.Division.Panel2.SuspendLayout();
            this.Division.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TxtIn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblMensaje, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 156);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TxtIn
            // 
            this.TxtIn.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtIn.Location = new System.Drawing.Point(3, 113);
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(400, 20);
            this.TxtIn.TabIndex = 0;
            this.TxtIn.TextoVacio = "<Descripcion>";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMensaje.Location = new System.Drawing.Point(3, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(400, 110);
            this.LblMensaje.TabIndex = 1;
            this.LblMensaje.Text = "label1";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(0, 0);
            this.Division.Name = "Division";
            this.Division.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Division.Panel1
            // 
            this.Division.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // Division.Panel2
            // 
            this.Division.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.Division.Size = new System.Drawing.Size(406, 195);
            this.Division.SplitterDistance = 156;
            this.Division.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Btn_Grabar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Cancelar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Grabar.Location = new System.Drawing.Point(247, 6);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Grabar.TabIndex = 1;
            this.Btn_Grabar.Text = "Grabar";
            this.ToolTipText.SetToolTip(this.Btn_Grabar, "Alamacena la información agregada");
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Cancelar.Location = new System.Drawing.Point(328, 6);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 0;
            this.Btn_Cancelar.Text = "Cancelar";
            this.ToolTipText.SetToolTip(this.Btn_Cancelar, "Cancela ");
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // InputMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 195);
            this.Controls.Add(this.Division);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputMensaje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InputMensaje_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Division.Panel1.ResumeLayout(false);
            this.Division.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button Btn_Grabar;
        public System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.ToolTip ToolTipText;
        public System.Windows.Forms.SplitContainer Division;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CuadroTexto TxtIn;
        private System.Windows.Forms.Label LblMensaje;
    }
}