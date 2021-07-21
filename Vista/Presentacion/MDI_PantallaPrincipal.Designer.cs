namespace RES.FrontEnd
{
    partial class MDI_PantallaPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_PantallaPrincipal));
            this.MenuPpal = new System.Windows.Forms.MenuStrip();
            this.timbradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tx = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolNotificador = new System.Windows.Forms.ToolTip(this.components);
            this.TabTimbradas = new System.Windows.Forms.TabPage();
            this.TableTimbradas = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTim_ReportVista = new System.Windows.Forms.Button();
            this.ImgListaBtn = new System.Windows.Forms.ImageList(this.components);
            this.BtnTim_ReportDetalle = new System.Windows.Forms.Button();
            this.BtnTim_ReportListadoEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTim_ReportResumen = new System.Windows.Forms.Button();
            this.BtnTim_AdminMan = new System.Windows.Forms.Button();
            this.BtnTim_AdminRev = new System.Windows.Forms.Button();
            this.BtnTim_AdminTim = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pagInicio = new System.Windows.Forms.TabPage();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.PanelSplit = new System.Windows.Forms.SplitContainer();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.TableConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdminUsuario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.MenuPpal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabTimbradas.SuspendLayout();
            this.TableTimbradas.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pagInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSplit)).BeginInit();
            this.PanelSplit.Panel1.SuspendLayout();
            this.PanelSplit.Panel2.SuspendLayout();
            this.PanelSplit.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.TableConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPpal
            // 
            this.MenuPpal.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.MenuPpal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timbradasToolStripMenuItem});
            this.MenuPpal.Location = new System.Drawing.Point(0, 0);
            this.MenuPpal.Name = "MenuPpal";
            this.MenuPpal.ShowItemToolTips = true;
            this.MenuPpal.Size = new System.Drawing.Size(824, 48);
            this.MenuPpal.TabIndex = 0;
            this.MenuPpal.Visible = false;
            // 
            // timbradasToolStripMenuItem
            // 
            this.timbradasToolStripMenuItem.Image = global::RES.FrontEnd.Properties.Resources.Timbrar;
            this.timbradasToolStripMenuItem.Name = "timbradasToolStripMenuItem";
            this.timbradasToolStripMenuItem.Size = new System.Drawing.Size(114, 44);
            this.timbradasToolStripMenuItem.Text = "Timbradas";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.Tx});
            this.statusStrip.Location = new System.Drawing.Point(0, 512);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(824, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Tx
            // 
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(118, 17);
            this.Tx.Text = "toolStripStatusLabel1";
            // 
            // TabTimbradas
            // 
            this.TabTimbradas.Controls.Add(this.TableTimbradas);
            this.TabTimbradas.ImageIndex = 0;
            this.TabTimbradas.Location = new System.Drawing.Point(39, 4);
            this.TabTimbradas.Name = "TabTimbradas";
            this.TabTimbradas.Padding = new System.Windows.Forms.Padding(3);
            this.TabTimbradas.Size = new System.Drawing.Size(137, 504);
            this.TabTimbradas.TabIndex = 0;
            this.TabTimbradas.Text = "Timbradas ";
            this.ToolNotificador.SetToolTip(this.TabTimbradas, "Administra el uso de las timbradas de los Empleados");
            this.TabTimbradas.UseVisualStyleBackColor = true;
            // 
            // TableTimbradas
            // 
            this.TableTimbradas.ColumnCount = 1;
            this.TableTimbradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableTimbradas.Controls.Add(this.button1, 0, 0);
            this.TableTimbradas.Controls.Add(this.BtnTim_ReportVista, 0, 8);
            this.TableTimbradas.Controls.Add(this.BtnTim_ReportDetalle, 0, 7);
            this.TableTimbradas.Controls.Add(this.BtnTim_ReportListadoEmpleado, 0, 6);
            this.TableTimbradas.Controls.Add(this.label1, 0, 1);
            this.TableTimbradas.Controls.Add(this.label2, 0, 5);
            this.TableTimbradas.Controls.Add(this.BtnTim_ReportResumen, 0, 9);
            this.TableTimbradas.Controls.Add(this.BtnTim_AdminMan, 0, 4);
            this.TableTimbradas.Controls.Add(this.BtnTim_AdminRev, 0, 3);
            this.TableTimbradas.Controls.Add(this.BtnTim_AdminTim, 0, 2);
            this.TableTimbradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTimbradas.Location = new System.Drawing.Point(3, 3);
            this.TableTimbradas.Name = "TableTimbradas";
            this.TableTimbradas.RowCount = 10;
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTimbradas.Size = new System.Drawing.Size(131, 498);
            this.TableTimbradas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::RES.FrontEnd.Properties.Resources.fingerprint;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Entrada/Salida";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnTim_ReportVista
            // 
            this.BtnTim_ReportVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_ReportVista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_ReportVista.ImageIndex = 7;
            this.BtnTim_ReportVista.ImageList = this.ImgListaBtn;
            this.BtnTim_ReportVista.Location = new System.Drawing.Point(3, 389);
            this.BtnTim_ReportVista.Name = "BtnTim_ReportVista";
            this.BtnTim_ReportVista.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_ReportVista.TabIndex = 8;
            this.BtnTim_ReportVista.Text = "Vista por Empleados";
            this.BtnTim_ReportVista.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_ReportVista.UseVisualStyleBackColor = true;
            this.BtnTim_ReportVista.Click += new System.EventHandler(this.BtnTim_ReportVista_Click);
            // 
            // ImgListaBtn
            // 
            this.ImgListaBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListaBtn.ImageStream")));
            this.ImgListaBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListaBtn.Images.SetKeyName(0, "reseller_account.png");
            this.ImgListaBtn.Images.SetKeyName(1, "table_row_delete.png");
            this.ImgListaBtn.Images.SetKeyName(2, "cog.png");
            this.ImgListaBtn.Images.SetKeyName(3, "table_gear.png");
            this.ImgListaBtn.Images.SetKeyName(4, "table_replace.png");
            this.ImgListaBtn.Images.SetKeyName(5, "telephone_key.png");
            this.ImgListaBtn.Images.SetKeyName(6, "print_preview16.png");
            this.ImgListaBtn.Images.SetKeyName(7, "printer.png");
            this.ImgListaBtn.Images.SetKeyName(8, "progressbar.png");
            this.ImgListaBtn.Images.SetKeyName(9, "server_information.png");
            this.ImgListaBtn.Images.SetKeyName(10, "server_stanchion.png");
            this.ImgListaBtn.Images.SetKeyName(11, "page_white_cup.png");
            this.ImgListaBtn.Images.SetKeyName(12, "email_to_friend.png");
            this.ImgListaBtn.Images.SetKeyName(13, "folder_go.png");
            this.ImgListaBtn.Images.SetKeyName(14, "document_layout.png");
            this.ImgListaBtn.Images.SetKeyName(15, "client_account_template.png");
            this.ImgListaBtn.Images.SetKeyName(16, "tab_edit.png");
            this.ImgListaBtn.Images.SetKeyName(17, "administrator.png");
            // 
            // BtnTim_ReportDetalle
            // 
            this.BtnTim_ReportDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_ReportDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_ReportDetalle.ImageIndex = 6;
            this.BtnTim_ReportDetalle.ImageList = this.ImgListaBtn;
            this.BtnTim_ReportDetalle.Location = new System.Drawing.Point(3, 338);
            this.BtnTim_ReportDetalle.Name = "BtnTim_ReportDetalle";
            this.BtnTim_ReportDetalle.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_ReportDetalle.TabIndex = 7;
            this.BtnTim_ReportDetalle.Text = "Detalle Timbradas";
            this.BtnTim_ReportDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_ReportDetalle.UseVisualStyleBackColor = true;
            this.BtnTim_ReportDetalle.Click += new System.EventHandler(this.BtnTim_ReportDetalle_Click);
            // 
            // BtnTim_ReportListadoEmpleado
            // 
            this.BtnTim_ReportListadoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_ReportListadoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_ReportListadoEmpleado.ImageIndex = 6;
            this.BtnTim_ReportListadoEmpleado.ImageList = this.ImgListaBtn;
            this.BtnTim_ReportListadoEmpleado.Location = new System.Drawing.Point(3, 287);
            this.BtnTim_ReportListadoEmpleado.Name = "BtnTim_ReportListadoEmpleado";
            this.BtnTim_ReportListadoEmpleado.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_ReportListadoEmpleado.TabIndex = 6;
            this.BtnTim_ReportListadoEmpleado.Text = "Listado de Empleados";
            this.BtnTim_ReportListadoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_ReportListadoEmpleado.UseVisualStyleBackColor = true;
            this.BtnTim_ReportListadoEmpleado.Click += new System.EventHandler(this.BtnTim_ReportListadoEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reportes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTim_ReportResumen
            // 
            this.BtnTim_ReportResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_ReportResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_ReportResumen.ImageIndex = 7;
            this.BtnTim_ReportResumen.ImageList = this.ImgListaBtn;
            this.BtnTim_ReportResumen.Location = new System.Drawing.Point(3, 440);
            this.BtnTim_ReportResumen.Name = "BtnTim_ReportResumen";
            this.BtnTim_ReportResumen.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_ReportResumen.TabIndex = 9;
            this.BtnTim_ReportResumen.Text = "Resumen";
            this.BtnTim_ReportResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_ReportResumen.UseVisualStyleBackColor = true;
            this.BtnTim_ReportResumen.Click += new System.EventHandler(this.BtnTim_ReportResumen_Click);
            // 
            // BtnTim_AdminMan
            // 
            this.BtnTim_AdminMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_AdminMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_AdminMan.ImageIndex = 5;
            this.BtnTim_AdminMan.ImageList = this.ImgListaBtn;
            this.BtnTim_AdminMan.Location = new System.Drawing.Point(3, 196);
            this.BtnTim_AdminMan.Name = "BtnTim_AdminMan";
            this.BtnTim_AdminMan.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_AdminMan.TabIndex = 4;
            this.BtnTim_AdminMan.Text = "Timbrar Manual";
            this.BtnTim_AdminMan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_AdminMan.UseVisualStyleBackColor = true;
            this.BtnTim_AdminMan.Click += new System.EventHandler(this.BtnTim_AdminMan_Click);
            // 
            // BtnTim_AdminRev
            // 
            this.BtnTim_AdminRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_AdminRev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_AdminRev.ImageIndex = 4;
            this.BtnTim_AdminRev.ImageList = this.ImgListaBtn;
            this.BtnTim_AdminRev.Location = new System.Drawing.Point(3, 145);
            this.BtnTim_AdminRev.Name = "BtnTim_AdminRev";
            this.BtnTim_AdminRev.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_AdminRev.TabIndex = 3;
            this.BtnTim_AdminRev.Text = "Revisión, Corrección";
            this.BtnTim_AdminRev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_AdminRev.UseVisualStyleBackColor = true;
            this.BtnTim_AdminRev.Click += new System.EventHandler(this.BtnTim_AdminRev_Click);
            // 
            // BtnTim_AdminTim
            // 
            this.BtnTim_AdminTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTim_AdminTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTim_AdminTim.ImageIndex = 0;
            this.BtnTim_AdminTim.ImageList = this.ImgListaBtn;
            this.BtnTim_AdminTim.Location = new System.Drawing.Point(3, 94);
            this.BtnTim_AdminTim.Name = "BtnTim_AdminTim";
            this.BtnTim_AdminTim.Size = new System.Drawing.Size(125, 45);
            this.BtnTim_AdminTim.TabIndex = 2;
            this.BtnTim_AdminTim.Text = "Empleados";
            this.BtnTim_AdminTim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTim_AdminTim.UseVisualStyleBackColor = true;
            this.BtnTim_AdminTim.Click += new System.EventHandler(this.BtnTim_AdminTim_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pagInicio);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ImageList = this.ImgList;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(640, 512);
            this.tabMain.TabIndex = 17;
            // 
            // pagInicio
            // 
            this.pagInicio.Controls.Add(this.panelContenedor);
            this.pagInicio.ImageIndex = 17;
            this.pagInicio.Location = new System.Drawing.Point(4, 55);
            this.pagInicio.Name = "pagInicio";
            this.pagInicio.Padding = new System.Windows.Forms.Padding(3);
            this.pagInicio.Size = new System.Drawing.Size(632, 453);
            this.pagInicio.TabIndex = 0;
            this.pagInicio.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(3, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(626, 447);
            this.panelContenedor.TabIndex = 16;
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "reseller_account.png");
            this.ImgList.Images.SetKeyName(1, "table_row_delete.png");
            this.ImgList.Images.SetKeyName(2, "cog.png");
            this.ImgList.Images.SetKeyName(3, "table_gear.png");
            this.ImgList.Images.SetKeyName(4, "table_replace.png");
            this.ImgList.Images.SetKeyName(5, "telephone_key.png");
            this.ImgList.Images.SetKeyName(6, "print_preview16.png");
            this.ImgList.Images.SetKeyName(7, "printer.png");
            this.ImgList.Images.SetKeyName(8, "progressbar.png");
            this.ImgList.Images.SetKeyName(9, "server_information.png");
            this.ImgList.Images.SetKeyName(10, "server_stanchion.png");
            this.ImgList.Images.SetKeyName(11, "page_white_cup.png");
            this.ImgList.Images.SetKeyName(12, "email_to_friend.png");
            this.ImgList.Images.SetKeyName(13, "folder_go.png");
            this.ImgList.Images.SetKeyName(14, "document_layout.png");
            this.ImgList.Images.SetKeyName(15, "client_account_template.png");
            this.ImgList.Images.SetKeyName(16, "tab_edit.png");
            this.ImgList.Images.SetKeyName(17, "Timbrar.png");
            // 
            // PanelSplit
            // 
            this.PanelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSplit.Location = new System.Drawing.Point(0, 0);
            this.PanelSplit.Name = "PanelSplit";
            // 
            // PanelSplit.Panel1
            // 
            this.PanelSplit.Panel1.Controls.Add(this.TabMenu);
            this.PanelSplit.Panel1MinSize = 80;
            // 
            // PanelSplit.Panel2
            // 
            this.PanelSplit.Panel2.Controls.Add(this.tabMain);
            this.PanelSplit.Size = new System.Drawing.Size(824, 512);
            this.PanelSplit.SplitterDistance = 180;
            this.PanelSplit.TabIndex = 20;
            // 
            // TabMenu
            // 
            this.TabMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabMenu.Controls.Add(this.TabTimbradas);
            this.TabMenu.Controls.Add(this.TabConfig);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenu.ImageList = this.ImgListaBtn;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Multiline = true;
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.ShowToolTips = true;
            this.TabMenu.Size = new System.Drawing.Size(180, 512);
            this.TabMenu.TabIndex = 0;
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.TableConfig);
            this.TabConfig.ImageIndex = 2;
            this.TabConfig.Location = new System.Drawing.Point(39, 4);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Size = new System.Drawing.Size(137, 504);
            this.TabConfig.TabIndex = 2;
            this.TabConfig.Text = "Configuración";
            this.TabConfig.UseVisualStyleBackColor = true;
            // 
            // TableConfig
            // 
            this.TableConfig.ColumnCount = 1;
            this.TableConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableConfig.Controls.Add(this.label5, 0, 0);
            this.TableConfig.Controls.Add(this.BtnAdminUsuario, 0, 1);
            this.TableConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableConfig.Location = new System.Drawing.Point(0, 0);
            this.TableConfig.Name = "TableConfig";
            this.TableConfig.RowCount = 10;
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableConfig.Size = new System.Drawing.Size(137, 504);
            this.TableConfig.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Administrar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdminUsuario
            // 
            this.BtnAdminUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminUsuario.ImageIndex = 17;
            this.BtnAdminUsuario.ImageList = this.ImgListaBtn;
            this.BtnAdminUsuario.Location = new System.Drawing.Point(3, 43);
            this.BtnAdminUsuario.Name = "BtnAdminUsuario";
            this.BtnAdminUsuario.Size = new System.Drawing.Size(125, 45);
            this.BtnAdminUsuario.TabIndex = 1;
            this.BtnAdminUsuario.Text = "Usuarios";
            this.BtnAdminUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAdminUsuario.UseVisualStyleBackColor = true;
            this.BtnAdminUsuario.Click += new System.EventHandler(this.BtnAdminUsuario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Image = global::RES.FrontEnd.Properties.Resources.cancel;
            this.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrar.Location = new System.Drawing.Point(729, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 46);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar Pestaña";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MDI_PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 534);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.PanelSplit);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.MenuPpal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPpal;
            this.MaximizeBox = false;
            this.Name = "MDI_PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MDIPrincipal2_Load);
            this.Resize += new System.EventHandler(this.MDI_PantallaPrincipal_Resize);
            this.MenuPpal.ResumeLayout(false);
            this.MenuPpal.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabTimbradas.ResumeLayout(false);
            this.TableTimbradas.ResumeLayout(false);
            this.TableTimbradas.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.pagInicio.ResumeLayout(false);
            this.PanelSplit.Panel1.ResumeLayout(false);
            this.PanelSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSplit)).EndInit();
            this.PanelSplit.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.TabConfig.ResumeLayout(false);
            this.TableConfig.ResumeLayout(false);
            this.TableConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip MenuPpal;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip ToolNotificador;
        private System.Windows.Forms.ToolStripStatusLabel Tx;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pagInicio;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.SplitContainer PanelSplit;
        private System.Windows.Forms.ToolStripMenuItem timbradasToolStripMenuItem;
        private System.Windows.Forms.ImageList ImgListaBtn;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage TabTimbradas;
        private System.Windows.Forms.TableLayoutPanel TableTimbradas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTim_ReportVista;
        private System.Windows.Forms.Button BtnTim_ReportDetalle;
        private System.Windows.Forms.Button BtnTim_ReportListadoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTim_AdminMan;
        private System.Windows.Forms.Button BtnTim_AdminRev;
        private System.Windows.Forms.Button BtnTim_AdminTim;
        private System.Windows.Forms.TabPage TabConfig;
        private System.Windows.Forms.TableLayoutPanel TableConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdminUsuario;
        private System.Windows.Forms.Button BtnTim_ReportResumen;
    }
}



