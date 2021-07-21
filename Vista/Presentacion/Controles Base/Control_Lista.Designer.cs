namespace RES.FrontEnd
{
    partial class Control_Lista
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
            this.DtVista = new System.Windows.Forms.DataGridView();
            this.MnuImagen = new System.Windows.Forms.ToolStrip();
            this.BtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBusq = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).BeginInit();
            this.MnuImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtVista
            // 
            this.DtVista.AllowUserToAddRows = false;
            this.DtVista.AllowUserToDeleteRows = false;
            this.DtVista.BackgroundColor = System.Drawing.Color.White;
            this.DtVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtVista.Location = new System.Drawing.Point(0, 39);
            this.DtVista.Name = "DtVista";
            this.DtVista.ReadOnly = true;
            this.DtVista.RowHeadersVisible = false;
            this.DtVista.Size = new System.Drawing.Size(671, 311);
            this.DtVista.TabIndex = 3;
            this.DtVista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_CellEnter);
            this.DtVista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtVista_CellFormatting);
            this.DtVista.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_RowEnter);
            // 
            // MnuImagen
            // 
            this.MnuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSelect,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TxtBusq});
            this.MnuImagen.Location = new System.Drawing.Point(0, 0);
            this.MnuImagen.Name = "MnuImagen";
            this.MnuImagen.Size = new System.Drawing.Size(671, 39);
            this.MnuImagen.TabIndex = 2;
            // 
            // BtnSelect
            // 
            this.BtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSelect.Image = global::RES.FrontEnd.ControlesPersonalizado.Properties.Resources.table_select_row;
            this.BtnSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(36, 36);
            this.BtnSelect.Text = "Nuevo";
            this.BtnSelect.ToolTipText = "Agrega Nuevo Registro";
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 36);
            this.toolStripLabel1.Text = "Búsqueda:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBusq
            // 
            this.TxtBusq.Name = "TxtBusq";
            this.TxtBusq.Size = new System.Drawing.Size(140, 39);
            this.TxtBusq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusq_KeyPress);
            // 
            // Control_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 350);
            this.Controls.Add(this.DtVista);
            this.Controls.Add(this.MnuImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Control_Lista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Control_Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).EndInit();
            this.MnuImagen.ResumeLayout(false);
            this.MnuImagen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DtVista;
        public System.Windows.Forms.ToolStrip MnuImagen;
        public System.Windows.Forms.ToolStripButton BtnSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripTextBox TxtBusq;
    }
}