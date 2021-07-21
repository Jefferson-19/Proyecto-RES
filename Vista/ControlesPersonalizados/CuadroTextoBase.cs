using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace RES.FrontEnd.ControlesPersonalizado
{
    public class CuadroTextoBase : CuadroTexto
    {
        #region Constructor
       
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == Convert.ToChar(127) | e.KeyChar == Convert.ToChar(8)) { e.Handled = false; }
            else { e.Handled = true; }
            base.OnKeyPress(e);
        }
        #endregion
    }
}
