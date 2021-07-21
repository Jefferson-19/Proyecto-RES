using System;
using System.Windows.Forms;

namespace RES.FrontEnd
{
    public partial class Frm_Login : Control_Acceso
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        public static int IsLogin = 0;
       
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Tx.TextoVacio = "Digite su Usuario";
            this.Tx.TextoVacio = "Digite su Clave";
            this.LblNombre.Text = "Usuario";
            this.Lb.Text = "Pasword";
            
        }
        public override void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.TxtPassword_KeyPress(sender, e);
            if (e.KeyChar==(char)Keys.Enter)
            {
                IsLogin = 1;
                this.Close();
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
