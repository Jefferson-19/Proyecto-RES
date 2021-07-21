using RES.FrontEnd.ControlesPersonalizado;
namespace RES.FrontEnd
{
    partial class FrmModSujetos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DatosPrincipales = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreSujeto = new CuadroTexto();
            this.TxtApellidoSujeto = new CuadroTexto();
            this.TxtTelefonoSujeto = new CuadroTextoBase();
            this.TxtDireccionSujeto = new CuadroTexto();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbGrupo = new Combo_Box();
            this.TxtTipoGrupo = new CuadroTexto();
            this.TxtIdTipoGrupo = new CuadroTexto();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCedula = new CuadroTextoBase();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.Identificacion = new System.Windows.Forms.TabPage();
            this.LblEstado = new System.Windows.Forms.Label();
            this.progressBar_R2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_R1 = new System.Windows.Forms.ProgressBar();
            this.PictureLectura2 = new System.Windows.Forms.PictureBox();
            this.PictureLectura1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtCard = new CuadroTexto();
            this.TxtBarcode = new CuadroTexto();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel1.SuspendLayout();
            this.Division.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DatosPrincipales.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.Identificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLectura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLectura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Division
            // 
            // 
            // Division.Panel1
            // 
            this.Division.Panel1.Controls.Add(this.tabControl1);
            this.Division.Size = new System.Drawing.Size(701, 369);
            this.Division.SplitterDistance = 318;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DatosPrincipales);
            this.tabControl1.Controls.Add(this.Identificacion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // DatosPrincipales
            // 
            this.DatosPrincipales.Controls.Add(this.tableLayoutPanel2);
            this.DatosPrincipales.Location = new System.Drawing.Point(4, 22);
            this.DatosPrincipales.Name = "DatosPrincipales";
            this.DatosPrincipales.Padding = new System.Windows.Forms.Padding(3);
            this.DatosPrincipales.Size = new System.Drawing.Size(693, 292);
            this.DatosPrincipales.TabIndex = 0;
            this.DatosPrincipales.Text = "Datos Principales";
            this.DatosPrincipales.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83688F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.16312F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PicImg, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(687, 286);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73832F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26168F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TxtNombreSujeto, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtApellidoSujeto, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtTelefonoSujeto, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.TxtDireccionSujeto, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.CmbGrupo, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.TxtTipoGrupo, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.TxtIdTipoGrupo, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtCedula, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(194, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 280);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombres :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellidos :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 66);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección Principal :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNombreSujeto
            // 
            this.TxtNombreSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNombreSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombreSujeto.Location = new System.Drawing.Point(109, 34);
            this.TxtNombreSujeto.Name = "TxtNombreSujeto";
            this.TxtNombreSujeto.Size = new System.Drawing.Size(256, 20);
            this.TxtNombreSujeto.TabIndex = 17;
            this.TxtNombreSujeto.TextoVacio = "";
            // 
            // TxtApellidoSujeto
            // 
            this.TxtApellidoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtApellidoSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtApellidoSujeto.Location = new System.Drawing.Point(109, 60);
            this.TxtApellidoSujeto.Name = "TxtApellidoSujeto";
            this.TxtApellidoSujeto.Size = new System.Drawing.Size(256, 20);
            this.TxtApellidoSujeto.TabIndex = 18;
            this.TxtApellidoSujeto.TextoVacio = "";
            // 
            // TxtTelefonoSujeto
            // 
            this.TxtTelefonoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtTelefonoSujeto.Location = new System.Drawing.Point(109, 86);
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
            this.TxtDireccionSujeto.Location = new System.Drawing.Point(109, 112);
            this.TxtDireccionSujeto.Multiline = true;
            this.TxtDireccionSujeto.Name = "TxtDireccionSujeto";
            this.TxtDireccionSujeto.Size = new System.Drawing.Size(256, 60);
            this.TxtDireccionSujeto.TabIndex = 20;
            this.TxtDireccionSujeto.TextoVacio = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Grupo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tipo Grupo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.FormattingEnabled = true;
            this.CmbGrupo.Location = new System.Drawing.Point(109, 198);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.Size = new System.Drawing.Size(183, 21);
            this.CmbGrupo.TabIndex = 23;
            this.CmbGrupo.SelectedIndexChanged += new System.EventHandler(this.CmbGrupo_SelectedIndexChanged);
            this.CmbGrupo.SelectedValueChanged += new System.EventHandler(this.CmbGrupo_SelectedValueChanged);
            // 
            // TxtTipoGrupo
            // 
            this.TxtTipoGrupo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtTipoGrupo.Location = new System.Drawing.Point(109, 225);
            this.TxtTipoGrupo.Name = "TxtTipoGrupo";
            this.TxtTipoGrupo.Size = new System.Drawing.Size(256, 20);
            this.TxtTipoGrupo.TabIndex = 24;
            this.TxtTipoGrupo.TextoVacio = "";
            // 
            // TxtIdTipoGrupo
            // 
            this.TxtIdTipoGrupo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtIdTipoGrupo.Location = new System.Drawing.Point(371, 225);
            this.TxtIdTipoGrupo.Name = "TxtIdTipoGrupo";
            this.TxtIdTipoGrupo.Size = new System.Drawing.Size(81, 20);
            this.TxtIdTipoGrupo.TabIndex = 25;
            this.TxtIdTipoGrupo.TextoVacio = "";
            this.TxtIdTipoGrupo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cédula :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCedula.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtCedula.Location = new System.Drawing.Point(109, 5);
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
            this.PicImg.Location = new System.Drawing.Point(16, 52);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(159, 181);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 3;
            this.PicImg.TabStop = false;
            this.PicImg.Click += new System.EventHandler(this.PicImg_Click);
            // 
            // Identificacion
            // 
            this.Identificacion.Controls.Add(this.LblEstado);
            this.Identificacion.Controls.Add(this.progressBar_R2);
            this.Identificacion.Controls.Add(this.progressBar_R1);
            this.Identificacion.Controls.Add(this.PictureLectura2);
            this.Identificacion.Controls.Add(this.PictureLectura1);
            this.Identificacion.Controls.Add(this.label9);
            this.Identificacion.Controls.Add(this.pictureBox3);
            this.Identificacion.Controls.Add(this.label10);
            this.Identificacion.Controls.Add(this.label8);
            this.Identificacion.Controls.Add(this.pictureBox2);
            this.Identificacion.Controls.Add(this.TxtCard);
            this.Identificacion.Controls.Add(this.TxtBarcode);
            this.Identificacion.Controls.Add(this.pictureBox1);
            this.Identificacion.Location = new System.Drawing.Point(4, 22);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Padding = new System.Windows.Forms.Padding(3);
            this.Identificacion.Size = new System.Drawing.Size(693, 292);
            this.Identificacion.TabIndex = 1;
            this.Identificacion.Text = "Identificación";
            this.Identificacion.UseVisualStyleBackColor = true;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(419, 40);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(0, 13);
            this.LblEstado.TabIndex = 45;
            // 
            // progressBar_R2
            // 
            this.progressBar_R2.Location = new System.Drawing.Point(538, 247);
            this.progressBar_R2.Name = "progressBar_R2";
            this.progressBar_R2.Size = new System.Drawing.Size(138, 12);
            this.progressBar_R2.TabIndex = 44;
            // 
            // progressBar_R1
            // 
            this.progressBar_R1.Location = new System.Drawing.Point(368, 244);
            this.progressBar_R1.Name = "progressBar_R1";
            this.progressBar_R1.Size = new System.Drawing.Size(138, 15);
            this.progressBar_R1.TabIndex = 43;
            // 
            // PictureLectura2
            // 
            this.PictureLectura2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLectura2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureLectura2.Enabled = false;
            this.InformarError.SetIconAlignment(this.PictureLectura2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.PictureLectura2.Image = global::RES.FrontEnd.Properties.Resources.Timbrar;
            this.PictureLectura2.Location = new System.Drawing.Point(538, 80);
            this.PictureLectura2.Name = "PictureLectura2";
            this.PictureLectura2.Size = new System.Drawing.Size(138, 158);
            this.PictureLectura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureLectura2.TabIndex = 42;
            this.PictureLectura2.TabStop = false;
            this.PictureLectura2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // PictureLectura1
            // 
            this.PictureLectura1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLectura1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureLectura1.Enabled = false;
            this.InformarError.SetIconAlignment(this.PictureLectura1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.PictureLectura1.Image = global::RES.FrontEnd.Properties.Resources.Timbrar;
            this.PictureLectura1.Location = new System.Drawing.Point(368, 80);
            this.PictureLectura1.Name = "PictureLectura1";
            this.PictureLectura1.Size = new System.Drawing.Size(138, 158);
            this.PictureLectura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureLectura1.TabIndex = 41;
            this.PictureLectura1.TabStop = false;
            this.PictureLectura1.Click += new System.EventHandler(this.PictureLectura_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Dedo Índice Derecho:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::RES.FrontEnd.Properties.Resources.fingerprint;
            this.pictureBox3.Location = new System.Drawing.Point(368, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tarjeta Magnética:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código de Barras";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RES.FrontEnd.Properties.Resources.card_back;
            this.pictureBox2.Location = new System.Drawing.Point(13, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TxtCard
            // 
            this.TxtCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCard.BackColor = System.Drawing.Color.White;
            this.TxtCard.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtCard.Location = new System.Drawing.Point(63, 80);
            this.TxtCard.Name = "TxtCard";
            this.TxtCard.PasswordChar = 'X';
            this.TxtCard.ReadOnly = true;
            this.TxtCard.Size = new System.Drawing.Size(282, 20);
            this.TxtCard.TabIndex = 36;
            this.TxtCard.TextoVacio = "Click para agregar";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.BackColor = System.Drawing.Color.White;
            this.TxtBarcode.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtBarcode.Location = new System.Drawing.Point(63, 140);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.PasswordChar = 'X';
            this.TxtBarcode.ReadOnly = true;
            this.TxtBarcode.Size = new System.Drawing.Size(282, 20);
            this.TxtBarcode.TabIndex = 35;
            this.TxtBarcode.TextoVacio = "Click para agregar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RES.FrontEnd.Properties.Resources.barcode;
            this.pictureBox1.Location = new System.Drawing.Point(13, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmModSujetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 369);
            this.Name = "FrmModSujetos";
            this.Load += new System.EventHandler(this.FrmAddSujetos_Load);
            this.Division.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DatosPrincipales.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.Identificacion.ResumeLayout(false);
            this.Identificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLectura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLectura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DatosPrincipales;
        private System.Windows.Forms.TabPage Identificacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private CuadroTexto TxtNombreSujeto;
        private CuadroTexto TxtApellidoSujeto;
        private CuadroTextoBase TxtTelefonoSujeto;
        private CuadroTexto TxtDireccionSujeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Combo_Box CmbGrupo;
        private CuadroTexto TxtTipoGrupo;
        private CuadroTexto TxtIdTipoGrupo;
        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.Label label7;
        private CuadroTextoBase TxtCedula;
        private System.Windows.Forms.PictureBox PictureLectura1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CuadroTexto TxtCard;
        private CuadroTexto TxtBarcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar_R2;
        private System.Windows.Forms.ProgressBar progressBar_R1;
        private System.Windows.Forms.PictureBox PictureLectura2;
        private System.Windows.Forms.Label LblEstado;
    }
}