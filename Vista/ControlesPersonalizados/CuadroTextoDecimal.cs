using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RES.FrontEnd.ControlesPersonalizado
{
    public class CuadroTextoDecimal:CuadroTextoBase
    {
        bool maximo = true;
        #region Metodos Re-escritos
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (this.TextLength==0){maximo = true;}    
            if (maximo)
            {
                if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else if (e.KeyChar == Convert.ToChar(127) | e.KeyChar == Convert.ToChar(8)) { e.Handled = false; }
                else if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    e.KeyChar = '.';
                    maximo = false;
                    e.Handled = false;
                }
                else { e.Handled = true;}
            }
            else
            {
                string[] wDecimal = this.Text.Trim().Split(new Char[] { '.' });
                if (wDecimal.Length >1)
                {
                    if (wDecimal[1].Length < 2)
                    {
                        if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
                        else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
                        else if (e.KeyChar == Convert.ToChar(127) | e.KeyChar == Convert.ToChar(8)) { e.Handled = false; }
                        else { e.Handled = true; }
                    }
                    else { e.Handled = true; }
                }
                else { maximo = true; }
            }
            
        }
        #endregion
    }
}
