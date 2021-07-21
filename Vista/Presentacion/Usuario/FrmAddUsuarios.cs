using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class FrmAddUsuarios : Control_Agregar_Pq
    {
        public FrmAddUsuarios(): base()
        {
            InitializeComponent();
            
        }

        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {
            base.Btn_Grabar_Click(sender, e);
            if ((this.TxtNombre.Text != "") & (this.TxtPass.Text != "") & (this.Tx.Text != "") & (this.TxtConfirmPass.Text != ""))
            {
              
                    MessageBox.Show("Usuario creado con éxito!!");
                    this.Close();
                
            }
            else { MessageBox.Show("Todos los campos son requeridos..."); }
        }
        private void FrmAds_Load(object sender, EventArgs e)
        {

        }
    }
}
