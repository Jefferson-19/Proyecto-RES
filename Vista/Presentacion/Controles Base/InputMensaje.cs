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
    public partial class InputMensaje : Form
    {
        public string Repuesta;
        public InputMensaje(string Texto, string MensajeCuadro)
        {
            InitializeComponent();
            this.TxtIn.TextoVacio = MensajeCuadro;
            this.LblMensaje.Text = Texto;

        }
        public void Btn_Grabar_Click(object sender, EventArgs e)
        {
            
            Repuesta = this.TxtIn.Text;
            this.Close();
        }
        
        private void InputMensaje_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Repuesta = "";
            this.Close();
        }
    }
}
