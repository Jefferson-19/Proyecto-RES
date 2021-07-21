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
    public partial class Control_Agregar_Pq : Form
    {
        
        InputMensaje InputBox;
        public Control_Agregar_Pq()
        {
            InitializeComponent();
           
        }
       
        public string MyInputBox(string Texto, string MensajeCuadro)
        { 
            InputBox = new InputMensaje(Texto,  MensajeCuadro);
            InputBox.ShowDialog();
            return InputBox.Repuesta;
        }
        public virtual void Control_Agregar_Pq_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Btn_Grabar_Click(object sender, EventArgs e)
        {

        }

      
    }
}
