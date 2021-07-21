namespace RES.FrontEnd
{
    partial class Control_Agregar_Pq
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
            this.Division = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.ToolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.InformarError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel2.SuspendLayout();
            this.Division.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).BeginInit();
            this.SuspendLayout();
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(0, 0);
            this.Division.Name = "Division";
            this.Division.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Division.Panel2
            // 
            this.Division.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.Division.Panel2MinSize = 60;
            this.Division.Size = new System.Drawing.Size(562, 305);
            this.Division.SplitterDistance = 240;
            this.Division.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Btn_Grabar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Cancelar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblMensaje, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancelar.Image = global::RES.FrontEnd.ControlesPersonalizado.Properties.Resources.cross_shield;
            this.Btn_Cancelar.Location = new System.Drawing.Point(484, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 55);
            this.Btn_Cancelar.TabIndex = 0;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTipText.SetToolTip(this.Btn_Cancelar, "Cancela ");
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // InformarError
            // 
            this.InformarError.ContainerControl = this;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.AutoSize = true;
            this.Btn_Grabar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Grabar.Image = global::RES.FrontEnd.ControlesPersonalizado.Properties.Resources.save32;
            this.Btn_Grabar.Location = new System.Drawing.Point(403, 3);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(75, 55);
            this.Btn_Grabar.TabIndex = 1;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTipText.SetToolTip(this.Btn_Grabar, "Alamacena la información agregada");
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMensaje.Location = new System.Drawing.Point(3, 0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(394, 61);
            this.LblMensaje.TabIndex = 2;
            // 
            // Control_Agregar_Pq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 305);
            this.Controls.Add(this.Division);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Control_Agregar_Pq";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Control_Agregar_Pq_Load);
            this.Division.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_Grabar;
        public System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.ToolTip ToolTipText;
        public System.Windows.Forms.SplitContainer Division;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ErrorProvider InformarError;
        private System.Windows.Forms.Label LblMensaje;
    }
}