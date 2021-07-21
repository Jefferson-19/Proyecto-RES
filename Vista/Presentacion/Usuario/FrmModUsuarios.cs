using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class FrmModUsuarios : Control_Agregar_Pq
    {

        public FrmModUsuarios() : base()
        {
            InitializeComponent();
          
        }

       
        public override void Btn_Grabar_Click(object sender, EventArgs e)
        {           
                base.Btn_Grabar_Click(sender, e);
                if ((this.TxtNombre.Text != "") & (this.TxtPass.Text != "") & (this.Tx.Text != "") & (this.TxtConfirmPass.Text != ""))
                {
                   
                        MessageBox.Show("Usuario actualizado!!");
                        this.Close();
                  
                }
                else { MessageBox.Show("Todos los campos son requeridos..."); }
        }

        private void FrmMos_Load(object sender, EventArgs e)
        {

        }

    }
}
