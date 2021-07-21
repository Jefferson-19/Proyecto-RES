using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class TimbradaManual : Control_Agregar_Pq
    {

        public TimbradaManual()
        {
            InitializeComponent();
        }
      

        private void Division_SplitterMoved(object sender, SplitterEventArgs e)
        { }
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
        
            MessageBox.Show("Datos Grabados con Exito!");
            this.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TimbradaManual_Load(object sender, EventArgs e)
        {

        }
        private void FechaCrearTimbrada_ValueChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void Turno1E_CheckedChanged(object sender, EventArgs e)
        {
            if (Turno1E.Checked) { this.Timbrada1.Enabled = true; } else { this.Timbrada1.Enabled = false; }
        }
        private void Turno1S_CheckedChanged(object sender, EventArgs e)
        {
            if (Turno1S.Checked) { this.Timbrada2.Enabled = true; } else { this.Timbrada2.Enabled = false; }
        }
        private void Turno2E_CheckedChanged(object sender, EventArgs e)
        {
            if (Turno2E.Checked) { this.Timbrada3.Enabled = true; } else { this.Timbrada3.Enabled = false; }
        }
        private void Turno2S_CheckedChanged(object sender, EventArgs e)
        {
            if (Turno2S.Checked) { this.Timbrada4.Enabled = true; } else { this.Timbrada4.Enabled = false; }
        }
        void Validar()
        {
         
        }
    }
    
}