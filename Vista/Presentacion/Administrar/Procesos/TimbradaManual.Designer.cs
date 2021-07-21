using RES.FrontEnd.ControlesPersonalizado;

namespace RES.FrontEnd
{
    partial class TimbradaManual
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreSujeto = new CuadroTexto();
            this.TxtApellidoSujeto = new CuadroTexto();
            this.TxtTelefonoSujeto = new CuadroTextoBase();
            this.FechaCrearTimbrada = new System.Windows.Forms.DateTimePicker();
            this.Dtvista = new System.Windows.Forms.DataGridView();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Timbrada1 = new System.Windows.Forms.DateTimePicker();
            this.Timbrada2 = new System.Windows.Forms.DateTimePicker();
            this.Timbrada3 = new System.Windows.Forms.DateTimePicker();
            this.Timbrada4 = new System.Windows.Forms.DateTimePicker();
            this.Turno1E = new System.Windows.Forms.CheckBox();
            this.Turno1S = new System.Windows.Forms.CheckBox();
            this.Turno2S = new System.Windows.Forms.CheckBox();
            this.Turno2E = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.Division.Panel1.SuspendLayout();
            this.Division.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtvista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Division
            // 
            // 
            // Division.Panel1
            // 
            this.Division.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.Division.Size = new System.Drawing.Size(534, 275);
            this.Division.SplitterDistance = 211;
            this.Division.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.Division_SplitterMoved);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 211);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.56446F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.43554F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PicImg, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(528, 121);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.05556F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.94444F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.TxtNombreSujeto, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.TxtApellidoSujeto, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TxtTelefonoSujeto, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.FechaCrearTimbrada, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.Dtvista, 2, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(132, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 115);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellidos :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha a Timbrar :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNombreSujeto
            // 
            this.TxtNombreSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNombreSujeto.Location = new System.Drawing.Point(99, 3);
            this.TxtNombreSujeto.Name = "TxtNombreSujeto";
            this.TxtNombreSujeto.ReadOnly = true;
            this.TxtNombreSujeto.Size = new System.Drawing.Size(187, 20);
            this.TxtNombreSujeto.TabIndex = 17;
            this.TxtNombreSujeto.TextoVacio = "";
            // 
            // TxtApellidoSujeto
            // 
            this.TxtApellidoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtApellidoSujeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtApellidoSujeto.Location = new System.Drawing.Point(99, 29);
            this.TxtApellidoSujeto.Name = "TxtApellidoSujeto";
            this.TxtApellidoSujeto.ReadOnly = true;
            this.TxtApellidoSujeto.Size = new System.Drawing.Size(242, 20);
            this.TxtApellidoSujeto.TabIndex = 18;
            this.TxtApellidoSujeto.TextoVacio = "";
            // 
            // TxtTelefonoSujeto
            // 
            this.TxtTelefonoSujeto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtTelefonoSujeto.Location = new System.Drawing.Point(99, 55);
            this.TxtTelefonoSujeto.MaxLength = 10;
            this.TxtTelefonoSujeto.Name = "TxtTelefonoSujeto";
            this.TxtTelefonoSujeto.ReadOnly = true;
            this.TxtTelefonoSujeto.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefonoSujeto.TabIndex = 19;
            this.TxtTelefonoSujeto.TextoVacio = "";
            // 
            // FechaCrearTimbrada
            // 
            this.FechaCrearTimbrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FechaCrearTimbrada.Location = new System.Drawing.Point(99, 86);
            this.FechaCrearTimbrada.Name = "FechaCrearTimbrada";
            this.FechaCrearTimbrada.Size = new System.Drawing.Size(226, 20);
            this.FechaCrearTimbrada.TabIndex = 20;
            this.FechaCrearTimbrada.ValueChanged += new System.EventHandler(this.FechaCrearTimbrada_ValueChanged);
            // 
            // Dtvista
            // 
            this.Dtvista.AllowUserToAddRows = false;
            this.Dtvista.AllowUserToDeleteRows = false;
            this.Dtvista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtvista.Location = new System.Drawing.Point(347, 81);
            this.Dtvista.Name = "Dtvista";
            this.Dtvista.ReadOnly = true;
            this.Dtvista.Size = new System.Drawing.Size(31, 22);
            this.Dtvista.TabIndex = 25;
            this.Dtvista.Visible = false;
            // 
            // PicImg
            // 
            this.PicImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicImg.Location = new System.Drawing.Point(9, 10);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(110, 101);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 3;
            this.PicImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 78);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(526, 76);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.Timbrada1, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.Timbrada2, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.Timbrada3, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.Timbrada4, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.Turno1E, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.Turno1S, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.Turno2S, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.Turno2E, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(520, 57);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // Timbrada1
            // 
            this.Timbrada1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timbrada1.Enabled = false;
            this.Timbrada1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timbrada1.Location = new System.Drawing.Point(134, 3);
            this.Timbrada1.Name = "Timbrada1";
            this.Timbrada1.ShowUpDown = true;
            this.Timbrada1.Size = new System.Drawing.Size(94, 20);
            this.Timbrada1.TabIndex = 21;
            // 
            // Timbrada2
            // 
            this.Timbrada2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Timbrada2.Enabled = false;
            this.Timbrada2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timbrada2.Location = new System.Drawing.Point(134, 32);
            this.Timbrada2.Name = "Timbrada2";
            this.Timbrada2.ShowUpDown = true;
            this.Timbrada2.Size = new System.Drawing.Size(94, 20);
            this.Timbrada2.TabIndex = 22;
            // 
            // Timbrada3
            // 
            this.Timbrada3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timbrada3.Enabled = false;
            this.Timbrada3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timbrada3.Location = new System.Drawing.Point(365, 3);
            this.Timbrada3.Name = "Timbrada3";
            this.Timbrada3.ShowUpDown = true;
            this.Timbrada3.Size = new System.Drawing.Size(94, 20);
            this.Timbrada3.TabIndex = 23;
            this.Timbrada3.Value = new System.DateTime(2014, 9, 10, 10, 24, 7, 0);
            // 
            // Timbrada4
            // 
            this.Timbrada4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timbrada4.Enabled = false;
            this.Timbrada4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timbrada4.Location = new System.Drawing.Point(365, 31);
            this.Timbrada4.Name = "Timbrada4";
            this.Timbrada4.ShowUpDown = true;
            this.Timbrada4.Size = new System.Drawing.Size(94, 20);
            this.Timbrada4.TabIndex = 24;
            // 
            // Turno1E
            // 
            this.Turno1E.AutoSize = true;
            this.Turno1E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Turno1E.Location = new System.Drawing.Point(59, 3);
            this.Turno1E.Name = "Turno1E";
            this.Turno1E.Size = new System.Drawing.Size(69, 22);
            this.Turno1E.TabIndex = 25;
            this.Turno1E.Text = "Entrada :";
            this.Turno1E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Turno1E.UseVisualStyleBackColor = true;
            this.Turno1E.CheckedChanged += new System.EventHandler(this.Turno1E_CheckedChanged);
            // 
            // Turno1S
            // 
            this.Turno1S.AutoSize = true;
            this.Turno1S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Turno1S.Location = new System.Drawing.Point(59, 31);
            this.Turno1S.Name = "Turno1S";
            this.Turno1S.Size = new System.Drawing.Size(69, 23);
            this.Turno1S.TabIndex = 26;
            this.Turno1S.Text = "Salida :";
            this.Turno1S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Turno1S.UseVisualStyleBackColor = true;
            this.Turno1S.CheckedChanged += new System.EventHandler(this.Turno1S_CheckedChanged);
            // 
            // Turno2S
            // 
            this.Turno2S.AutoSize = true;
            this.Turno2S.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Turno2S.Location = new System.Drawing.Point(290, 31);
            this.Turno2S.Name = "Turno2S";
            this.Turno2S.Size = new System.Drawing.Size(69, 23);
            this.Turno2S.TabIndex = 27;
            this.Turno2S.Text = "Salida :";
            this.Turno2S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Turno2S.UseVisualStyleBackColor = true;
            this.Turno2S.CheckedChanged += new System.EventHandler(this.Turno2S_CheckedChanged);
            // 
            // Turno2E
            // 
            this.Turno2E.AutoSize = true;
            this.Turno2E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Turno2E.Location = new System.Drawing.Point(290, 3);
            this.Turno2E.Name = "Turno2E";
            this.Turno2E.Size = new System.Drawing.Size(69, 22);
            this.Turno2E.TabIndex = 28;
            this.Turno2E.Text = "Entrada :";
            this.Turno2E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Turno2E.UseVisualStyleBackColor = true;
            this.Turno2E.CheckedChanged += new System.EventHandler(this.Turno2E_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(520, 7);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 7);
            this.label9.TabIndex = 0;
            this.label9.Text = "Turno 1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 7);
            this.label10.TabIndex = 1;
            this.label10.Text = "Turno 2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimbradaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 275);
            this.Name = "TimbradaManual";
            this.Load += new System.EventHandler(this.TimbradaManual_Load);
            this.Division.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.Division.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InformarError)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtvista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private CuadroTexto TxtNombreSujeto;
        private CuadroTexto TxtApellidoSujeto;
        private CuadroTextoBase TxtTelefonoSujeto;
        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DateTimePicker FechaCrearTimbrada;
        private System.Windows.Forms.DateTimePicker Timbrada1;
        private System.Windows.Forms.DateTimePicker Timbrada2;
        private System.Windows.Forms.DateTimePicker Timbrada3;
        private System.Windows.Forms.DateTimePicker Timbrada4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dtvista;
        private System.Windows.Forms.CheckBox Turno1E;
        private System.Windows.Forms.CheckBox Turno1S;
        private System.Windows.Forms.CheckBox Turno2S;
        private System.Windows.Forms.CheckBox Turno2E;
    }
}