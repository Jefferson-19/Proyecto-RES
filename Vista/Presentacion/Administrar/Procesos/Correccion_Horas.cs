using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class Correccion_Horas : Control_Agregar_Pq
    {   public Correccion_Horas()
        {
            InitializeComponent();
        }
       
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Correccion_Horas_Load(object sender, EventArgs e)
        {

        }
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
                MessageBox.Show("Datos Grabados con Exito!");
                this.Close();
            
        }

        private void DtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
