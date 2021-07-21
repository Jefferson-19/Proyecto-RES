using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    partial class Control_Principal_Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Principal_Vista));
            this.MnuImagen = new System.Windows.Forms.ToolStrip();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnOpcion = new System.Windows.Forms.ToolStripButton();
            this.BtnOpcion2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.CmbFiltro = new RES.FrontEnd.ControlesPersonalizado.Combo_ToolStrip();
            this.DtVista = new System.Windows.Forms.DataGridView();
            this.MnuImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuImagen
            // 
            this.MnuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.BtnModificar,
            this.BtnEliminar,
            this.toolStripSeparator3,
            this.BtnOpcion,
            this.BtnOpcion2,
            this.toolStripSeparator1,
            this.BtnRefresh,
            this.toolStripSeparator2,
            this.LblFiltro,
            this.CmbFiltro});
            this.MnuImagen.Location = new System.Drawing.Point(0, 0);
            this.MnuImagen.Name = "MnuImagen";
            this.MnuImagen.Size = new System.Drawing.Size(657, 39);
            this.MnuImagen.TabIndex = 0;
            this.MnuImagen.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuImagen_ItemClicked);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(36, 36);
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.ToolTipText = "Agrega Nuevo Registro";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(36, 36);
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.ToolTipText = "Modifica el registro seleccionado";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(36, 36);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.ToolTipText = "Elimina el registro seleccionado";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // BtnOpcion
            // 
            this.BtnOpcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpcion.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpcion.Image")));
            this.BtnOpcion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnOpcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpcion.Name = "BtnOpcion";
            this.BtnOpcion.Size = new System.Drawing.Size(23, 36);
            this.BtnOpcion.Visible = false;
            this.BtnOpcion.Click += new System.EventHandler(this.BtnOpcion_Click);
            // 
            // BtnOpcion2
            // 
            this.BtnOpcion2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpcion2.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpcion2.Image")));
            this.BtnOpcion2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnOpcion2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpcion2.Name = "BtnOpcion2";
            this.BtnOpcion2.Size = new System.Drawing.Size(23, 36);
            this.BtnOpcion2.Visible = false;
            this.BtnOpcion2.Click += new System.EventHandler(this.BtnOpcion2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(36, 36);
            this.BtnRefresh.Text = "Actualiza ";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRefresh.ToolTipText = "Actualiza registros";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // LblFiltro
            // 
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(0, 36);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(180, 39);
            this.CmbFiltro.ToolTipText = "Filtro";
            this.CmbFiltro.SelectedIndexChanged += new System.EventHandler(this.CmbFiltro_SelectedIndexChanged);
            this.CmbFiltro.Click += new System.EventHandler(this.CmbFiltro_Click);
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
            this.DtVista.Size = new System.Drawing.Size(657, 317);
            this.DtVista.TabIndex = 1;
            this.DtVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_CellContentClick);
            this.DtVista.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_CellContentDoubleClick);
            this.DtVista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtVista_CellFormatting);
            this.DtVista.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_RowEnter);
            this.DtVista.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtVista_RowHeaderMouseClick);
            // 
            // Control_Principal_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 356);
            this.Controls.Add(this.DtVista);
            this.Controls.Add(this.MnuImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Control_Principal_Vista";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Control_Principal_Vista_Load);
            this.MnuImagen.ResumeLayout(false);
            this.MnuImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton BtnNuevo;
        public System.Windows.Forms.ToolStripButton BtnModificar;
        public System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStrip MnuImagen;
        public System.Windows.Forms.DataGridView DtVista;
        public System.Windows.Forms.ToolStripLabel LblFiltro;
        public Combo_ToolStrip CmbFiltro;
        public System.Windows.Forms.ToolStripButton BtnOpcion;
        public System.Windows.Forms.ToolStripButton BtnOpcion2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}