using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    
    partial class Calcular_Horas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtVista = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new Combo_Box();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreSujeto = new CuadroTexto();
            this.TxtApellidoSujeto = new CuadroTexto();
            this.TxtTelefonoSujeto = new CuadroTextoBase();
            this.TxtDireccionSujeto = new CuadroTexto();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCedula = new CuadroTextoBase();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DtHorasXDia = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DtTimbradas = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Mes = new Combo_Box();
            this.BtnCorregir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmb_Anio = new Combo_Box();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel1.SuspendLayout();
            this.Division.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtHorasXDia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtTimbradas)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Division
            // 
            // 
            // Division.Panel1
            // 
            this.Division.Panel1.Controls.Add(this.splitContainer1);
            this.Division.Size = new System.Drawing.Size(988, 551);
            this.Division.SplitterDistance = 487;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(988, 487);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CmbFiltro, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(319, 487);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Grupo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DtVista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 421);
            this.panel1.TabIndex = 3;
            // 
            // DtVista
            // 
            this.DtVista.AllowUserToAddRows = false;
            this.DtVista.AllowUserToDeleteRows = false;
            this.DtVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtVista.Location = new System.Drawing.Point(0, 0);
            this.DtVista.Name = "DtVista";
            this.DtVista.ReadOnly = true;
            this.DtVista.RowHeadersVisible = false;
            this.DtVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVista.Size = new System.Drawing.Size(311, 419);
            this.DtVista.TabIndex = 0;
            this.DtVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_CellContentClick);
            this.DtVista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVista_CellEnter);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Location = new System.Drawing.Point(3, 33);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(196, 21);
            this.CmbFiltro.TabIndex = 4;
            this.CmbFiltro.SelectedValueChanged += new System.EventHandler(this.CmbFiltro_SelectedValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(665, 487);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 175);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83688F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.16312F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.PicImg, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(657, 173);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.45946F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.54054F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.TxtNombreSujeto, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.TxtApellidoSujeto, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.TxtTelefonoSujeto, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.TxtDireccionSujeto, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.TxtCedula, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(185, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(469, 167);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(43, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombres :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(43, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellidos :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(43, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 66);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección Principal :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNombreSujeto
            // 
            this.TxtNombreSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNombreSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombreSujeto.Location = new System.Drawing.Point(143, 26);
            this.TxtNombreSujeto.Name = "TxtNombreSujeto";
            this.TxtNombreSujeto.Size = new System.Drawing.Size(234, 20);
            this.TxtNombreSujeto.TabIndex = 17;
            this.TxtNombreSujeto.TextoVacio = "";
            // 
            // TxtApellidoSujeto
            // 
            this.TxtApellidoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtApellidoSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtApellidoSujeto.Location = new System.Drawing.Point(143, 52);
            this.TxtApellidoSujeto.Name = "TxtApellidoSujeto";
            this.TxtApellidoSujeto.Size = new System.Drawing.Size(234, 20);
            this.TxtApellidoSujeto.TabIndex = 18;
            this.TxtApellidoSujeto.TextoVacio = "";
            // 
            // TxtTelefonoSujeto
            // 
            this.TxtTelefonoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtTelefonoSujeto.Location = new System.Drawing.Point(143, 78);
            this.TxtTelefonoSujeto.MaxLength = 10;
            this.TxtTelefonoSujeto.Name = "TxtTelefonoSujeto";
            this.TxtTelefonoSujeto.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefonoSujeto.TabIndex = 19;
            this.TxtTelefonoSujeto.TextoVacio = "";
            // 
            // TxtDireccionSujeto
            // 
            this.TxtDireccionSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtDireccionSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDireccionSujeto.Location = new System.Drawing.Point(143, 104);
            this.TxtDireccionSujeto.Multiline = true;
            this.TxtDireccionSujeto.Name = "TxtDireccionSujeto";
            this.TxtDireccionSujeto.Size = new System.Drawing.Size(234, 60);
            this.TxtDireccionSujeto.TabIndex = 20;
            this.TxtDireccionSujeto.TextoVacio = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(43, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Identificación :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCedula.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtCedula.Location = new System.Drawing.Point(143, 3);
            this.TxtCedula.MaxLength = 13;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(123, 20);
            this.TxtCedula.TabIndex = 16;
            this.TxtCedula.TextoVacio = "";
            // 
            // PicImg
            // 
            this.PicImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicImg.InitialImage = global::RES.FrontEnd.Properties.Resources.reseller_account;
            this.PicImg.Location = new System.Drawing.Point(11, 3);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(159, 167);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 3;
            this.PicImg.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 250);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(659, 234);
            this.splitContainer2.SplitterDistance = 365;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DtHorasXDia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 234);
            this.panel3.TabIndex = 0;
            // 
            // DtHorasXDia
            // 
            this.DtHorasXDia.AllowUserToAddRows = false;
            this.DtHorasXDia.AllowUserToDeleteRows = false;
            this.DtHorasXDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtHorasXDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtHorasXDia.Location = new System.Drawing.Point(0, 0);
            this.DtHorasXDia.Name = "DtHorasXDia";
            this.DtHorasXDia.ReadOnly = true;
            this.DtHorasXDia.RowHeadersVisible = false;
            this.DtHorasXDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtHorasXDia.Size = new System.Drawing.Size(363, 232);
            this.DtHorasXDia.TabIndex = 1;
            this.DtHorasXDia.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtHorasXDia_CellEnter);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DtTimbradas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 234);
            this.panel4.TabIndex = 1;
            // 
            // DtTimbradas
            // 
            this.DtTimbradas.AllowUserToAddRows = false;
            this.DtTimbradas.AllowUserToDeleteRows = false;
            this.DtTimbradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtTimbradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtTimbradas.Location = new System.Drawing.Point(0, 0);
            this.DtTimbradas.Name = "DtTimbradas";
            this.DtTimbradas.ReadOnly = true;
            this.DtTimbradas.RowHeadersVisible = false;
            this.DtTimbradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtTimbradas.Size = new System.Drawing.Size(288, 232);
            this.DtTimbradas.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 60);
            this.panel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 9;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.Cmb_Mes, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.BtnCorregir, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.Cmb_Anio, 5, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(657, 58);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 58);
            this.label5.TabIndex = 0;
            this.label5.Text = " Mes :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Mes
            // 
            this.Cmb_Mes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_Mes.FormattingEnabled = true;
            this.Cmb_Mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cmb_Mes.Location = new System.Drawing.Point(126, 18);
            this.Cmb_Mes.Name = "Cmb_Mes";
            this.Cmb_Mes.Size = new System.Drawing.Size(182, 21);
            this.Cmb_Mes.TabIndex = 1;
            this.Cmb_Mes.SelectedValueChanged += new System.EventHandler(this.Cmb_Mes_SelectedValueChanged);
            // 
            // BtnCorregir
            // 
            this.BtnCorregir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCorregir.Enabled = false;
            this.BtnCorregir.Image = global::RES.FrontEnd.Properties.Resources.tab_edit;
            this.BtnCorregir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCorregir.Location = new System.Drawing.Point(527, 3);
            this.BtnCorregir.Name = "BtnCorregir";
            this.BtnCorregir.Size = new System.Drawing.Size(64, 52);
            this.BtnCorregir.TabIndex = 2;
            this.BtnCorregir.Text = "Corregir";
            this.BtnCorregir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCorregir.UseVisualStyleBackColor = true;
            this.BtnCorregir.Click += new System.EventHandler(this.BtnCorregir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 58);
            this.label7.TabIndex = 3;
            this.label7.Text = "Año :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Anio
            // 
            this.Cmb_Anio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_Anio.FormattingEnabled = true;
            this.Cmb_Anio.Location = new System.Drawing.Point(387, 18);
            this.Cmb_Anio.Name = "Cmb_Anio";
            this.Cmb_Anio.Size = new System.Drawing.Size(72, 21);
            this.Cmb_Anio.TabIndex = 4;
            // 
            // Calcular_Horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "Calcular_Horas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calcular_Horas_Load);
            this.Division.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtVista)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtHorasXDia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtTimbradas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DtVista;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private Combo_Box CmbFiltro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private Combo_Box Cmb_Mes;
        private System.Windows.Forms.Button BtnCorregir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private CuadroTexto TxtNombreSujeto;
        private CuadroTexto TxtApellidoSujeto;
        private CuadroTextoBase TxtTelefonoSujeto;
        private CuadroTexto TxtDireccionSujeto;
        private System.Windows.Forms.Label label8;
        private CuadroTextoBase TxtCedula;
        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DtHorasXDia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DtTimbradas;
        private System.Windows.Forms.Label label7;
        private Combo_Box Cmb_Anio;
    }
}